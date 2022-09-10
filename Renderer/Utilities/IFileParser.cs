using System.Numerics;
using Renderer.Models;

namespace Renderer.Utilities;

public interface IFileParser
{
	Task<RenderObject> ParseFile(string filepath);
	void ParseLine(string input);
	Vertex ParseVertex(string[] inputValues);
	Vector3 ParseTextureCoordinates(string[] inputValues);
	Vector3 ParseNormalVector(string[] inputValues);
	Polygon ParsePolygon(string[] inputValues);
}
