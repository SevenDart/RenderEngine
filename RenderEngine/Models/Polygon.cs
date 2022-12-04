using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class Polygon
{
	public List<Vertex> Vertices { get; set; } = new();
	public List<Vector3?> TextureCoordinates { get; set; } = new();
	public List<Vector3?> NormalVectors { get; set; } = new();
	public Material? Material { get; set; }

	public Vector3 GetNormalVector()
	{
		return Vector3.Normalize(Vector3.Cross(
			Vertices[1].Coordinates - Vertices[0].Coordinates,
			Vertices[2].Coordinates - Vertices[0].Coordinates));
	}
}
