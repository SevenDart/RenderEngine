using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;

namespace RenderEngine.Utilities;

public class ObjFileParser : IFileParser
{
	private readonly List<Vertex> _vertices = new();
	private readonly List<Vector3> _vertexTextures = new();
	private readonly List<Vector3> _vertexNormals = new();
	private readonly List<RenderObject> _renderObjects = new();
	private string _currentFileName = null!;
	private string _currentFilepath = null!;

	private List<Material> _materials = new();
	private Material? _currentMaterial = null;
	private readonly IMaterialParser _materialParser = new MaterialParser();

	public async Task<List<RenderObject>> ParseFile(string filepath)
	{
		ClearData();
		_currentFileName = Path.GetFileNameWithoutExtension(filepath);
		_currentFilepath = filepath;

		using var file = new StreamReader(filepath);

		while (!file.EndOfStream)
		{
			var line = await file.ReadLineAsync();
			if (line != null && line.Length > 0) 
				await ParseLine(line);
		}

		return _renderObjects;
	}

	private async Task ParseLine(string input)
	{
		var spaceIndex = input.IndexOf(' ');
		if (spaceIndex == -1)
		{
			return;
		}

		var lineType = input.Substring(0, spaceIndex);
		var inputValues = input.Substring(spaceIndex + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);

		switch (lineType)
		{
			case "mtllib":
				var materialFileName = Path.Combine(Path.GetDirectoryName(_currentFilepath), inputValues[0]);
				if (File.Exists(materialFileName))
				{
					_materials = await _materialParser.ParseFile(materialFileName);
				}
				break;
			case "v":
				var vertex = ParseVertex(inputValues);
				vertex.Index = _vertices.Count + 1;
				_vertices.Add(vertex);
				break;
			case "vt":
				var textureCoordinates = ParseTextureCoordinates(inputValues);
				_vertexTextures.Add(textureCoordinates);
				break;
			case "vn":
				var normalVector = ParseNormalVector(inputValues);
				_vertexNormals.Add(normalVector);
				break;
			
			case "f":
				var polygons = ParseTriangulatedPolygon(inputValues);
				if (_renderObjects.Count == 0)
				{
					var unnamedRenderObject = new RenderObject
					{
						Name = _currentFileName,
						Pivot = new Pivot()
						{
							Translation = new Vector3(0, 0, 0)
						}
					};
					_renderObjects.Add(unnamedRenderObject);
				}

				foreach (var polygon in polygons)
				{
					polygon.Material = _currentMaterial;
				}
				
				_renderObjects.Last().Polygons.AddRange(polygons);
				break;
			
			case "o":
				var renderObject = new RenderObject
				{
					Name = string.Concat(inputValues),
					Pivot = new Pivot()
					{
						Translation = new Vector3(0, 0, 0)
					}
				};
				_renderObjects.Add(renderObject);
				break;
			
			case "usemtl":
				_currentMaterial = _materials.First(m => m.Name == string.Concat(inputValues));
				break;
		}
	}

	public Vertex ParseVertex(string[] inputValues)
	{
		var vertex = new Vertex();

		vertex.Coordinates = new Vector3(float.Parse(inputValues[0]), float.Parse(inputValues[1]), float.Parse(inputValues[2]));

		if (inputValues.Length > 3)
		{
			vertex.WCoordinate = float.Parse(inputValues[3]);
		}

		return vertex;
	}

	public Vector3 ParseTextureCoordinates(string[] inputValues)
	{
		var coordinates = new Vector3(float.Parse(inputValues[0]))
		{
			Y = inputValues.Length > 1 ? float.Parse(inputValues[1]) : 0,
			Z = inputValues.Length > 2 ? float.Parse(inputValues[2]) : 0
		};

		return coordinates;
	}

	public Vector3 ParseNormalVector(string[] inputValues)
	{
		return new Vector3(float.Parse(inputValues[0]), float.Parse(inputValues[1]), float.Parse(inputValues[2]));
	}

	public IEnumerable<Polygon> ParseTriangulatedPolygon(string[] inputValues)
	{
		var polygonVertices = new List<PolygonVertex>(); 

		foreach (var inputValue in inputValues)
		{
			var vertexValues = inputValue.Split('/');
			
			var index = int.Parse(vertexValues[0]);
			index = index < 0 ? _vertices.Count - Math.Abs(index) : index - 1;
			
			var polygonVertex = new PolygonVertex()
			{
				Vertex = _vertices[index]
			};

			if (vertexValues.Length > 1 && vertexValues[1] != "")
			{
				index = int.Parse(vertexValues[1]);
				index = index < 0 ? _vertexTextures.Count - Math.Abs(index) : index - 1;
				polygonVertex.TextureCoordinate = _vertexTextures[index];
			}
			
			if (vertexValues.Length > 2 && vertexValues[2] != "")
			{
				index = int.Parse(vertexValues[2]);
				index = index < 0 ? _vertexNormals.Count - Math.Abs(index) : index - 1;
				polygonVertex.NormalVector = _vertexNormals[index];
			}
			polygonVertices.Add(polygonVertex);
		}

		return TriangulatePolygon(polygonVertices.ToArray());
	}


	private IEnumerable<Polygon> TriangulatePolygon(PolygonVertex[] vertices)
	{
		if (vertices.Length == 3)
		{
			return new Polygon[]
			{
				new() { 
					Vertices = vertices.Select(pv => pv.Vertex).ToList(), 
					TextureCoordinates = vertices.Select(pv => pv.TextureCoordinate).ToList(),
					NormalVectors = vertices.Select(pv => pv.NormalVector).ToList()
				}
			};
		}
		
		var polygons = new List<Polygon>();

		var innerVertices = new List<PolygonVertex>();

		int index = 2;
		for (; index < vertices.Length; index += 2)
		{
			if (index % 2 == 0)
			{
				innerVertices.Add(vertices[index]);
				polygons.Add(new Polygon() { 
					Vertices = new List<Vertex> {
						vertices[index - 2].Vertex,
						vertices[index - 1].Vertex,
						vertices[index].Vertex
					},
					TextureCoordinates = new List<Vector3?>()
					{
						vertices[index - 2].TextureCoordinate,
						vertices[index - 1].TextureCoordinate,
						vertices[index - 0].TextureCoordinate,
					},
					NormalVectors = new List<Vector3?>()
					{
						vertices[index - 2].NormalVector,
						vertices[index - 1].NormalVector,
						vertices[index - 0].NormalVector,
					},
				});
			}
		}


		if (vertices.Length % 2 == 0)
		{
			innerVertices.Add(vertices[^1]);
		}
		innerVertices.Add(vertices[0]);

		polygons.AddRange(TriangulatePolygon(innerVertices.ToArray()));
		return polygons;
	}

	private void ClearData()
	{
		_vertices.Clear();
		_vertexTextures.Clear();
		_vertexNormals.Clear();
		_renderObjects.Clear();
		_materials.Clear();
		_currentMaterial = null;
	}

	private class PolygonVertex
	{
		public Vertex Vertex;
		public Vector3? TextureCoordinate;
		public Vector3? NormalVector;
	}
}
