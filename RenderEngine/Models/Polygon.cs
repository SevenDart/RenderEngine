using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class Polygon
{
	public List<Vertex> Vertices { get; set; } = new();

	public Vector3 GetNormalVector(MatrixBox transformMatrix)
	{
		var zeroPoint = Vector3.Transform(Vertices[0].Coordinates, transformMatrix.Matrix);
		var firstPoint = Vector3.Transform(Vertices[1].Coordinates, transformMatrix.Matrix);
		var secondPoint = Vector3.Transform(Vertices[2].Coordinates, transformMatrix.Matrix);
		
		return Vector3.Normalize(-Vector3.Cross(
			firstPoint - zeroPoint,
			secondPoint - zeroPoint));
	}
}
