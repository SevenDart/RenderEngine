using System.Numerics;
using RenderEngine.Models;

namespace RenderEngine.Utilities;

public interface IFileParser
{
	Task<RenderObject> ParseFile(string filepath);
	void ParseLine(string input);
	Vertex ParseVertex(string[] inputValues);
	Vector3 ParseTextureCoordinates(string[] inputValues);
	Vector3 ParseNormalVector(string[] inputValues);
	IEnumerable<Polygon> ParseTriangulatedPolygon(string[] inputValues);
}
