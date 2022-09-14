using System.Numerics;
using RenderEngine.Models;

namespace RenderEngine.Utilities.Implementations;

public class ObjFileParser : IFileParser
{
	private readonly List<Vertex> _vertices = new();
	private readonly List<Vector3> _vertexTextures = new();
	private readonly List<Vector3> _vertexNormals = new();
	private readonly List<Polygon> _polygons = new();

	public async Task<RenderObject> ParseFile(string filepath)
	{
		ClearData();
		
		using var file = new StreamReader(filepath);

		while (!file.EndOfStream)
		{
			var line = await file.ReadLineAsync();
			if (line != null && line.Length > 0) 
				ParseLine(line);
		}

		var renderObject = new RenderObject()
		{
			Name = Path.GetFileName(filepath),
			Pivot = new Pivot()
			{
				Center = new Vector3(0, 0, 0)
			}
		};

		renderObject.Polygons.AddRange(_polygons);

		return renderObject;
	}

	public void ParseLine(string input)
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
			case "v":
				var vertex = ParseVertex(inputValues);
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
				var polygon = ParsePolygon(inputValues);
				_polygons.Add(polygon);
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

	public Polygon ParsePolygon(string[] inputValues)
	{
		var polygon = new Polygon();

		foreach (var inputValue in inputValues)
		{
			var vertexValues = inputValue.Split('/');
			
			var index = int.Parse(vertexValues[0]);
			index = index < 0 ? _vertices.Count - Math.Abs(index) : index - 1;
			
			var vertex = _vertices[index];
			
			if (vertexValues.Length > 1 && vertexValues[1] != "")
			{
				index = int.Parse(vertexValues[1]);
				index = index < 0 ? _vertexTextures.Count - Math.Abs(index) : index - 1;
				vertex.TextureCoordinates = _vertexTextures[index];
			}
			
			if (vertexValues.Length > 2 && vertexValues[2] != "")
			{
				index = int.Parse(vertexValues[2]);
				index = index < 0 ? _vertexNormals.Count - Math.Abs(index) : index - 1;
				vertex.NormalVector = _vertexNormals[index];
			}
			polygon.Vertices.Add(vertex);
		}

		return polygon;
	}

	private Pivot GetPivot()
	{
		var pivot = new Pivot
		{
			Center = new Vector3()
			{
				X = _vertices.Sum(v => v.Coordinates.X) / _vertices.Count,
				Y = _vertices.Sum(v => v.Coordinates.Y) / _vertices.Count,
				Z = _vertices.Sum(v => v.Coordinates.Z) / _vertices.Count
			}
		};

		return pivot;
	}

	private void ClearData()
	{
		_vertices.Clear();
		_vertexTextures.Clear();
		_vertexNormals.Clear();
		_polygons.Clear();
	}
}
