using System.Drawing;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Pivot Pivot { get; set; } = null!;
	public MatrixBox TransformationMatrix { get; set; } = new(new Matrix4x4());
	public Color BaseColor { get; set; } = Color.Cyan;

	public virtual void RefreshTransformationMatrix()
	{
		var newModelMatrix = Pivot.CreateModelMatrix();
		
		if (newModelMatrix == TransformationMatrix.Matrix)
			return;

		TransformationMatrix.Matrix = newModelMatrix;

		foreach (var polygon in Polygons)
		{
			foreach (var vertex in polygon.Vertices)
			{
				vertex.GlobalCoordinates = Vector3.Transform(vertex.Coordinates, newModelMatrix);
			}
		}
		
	}

	public virtual void Rotate(Vector3 rotationVector)
	{
		Pivot.Rotation += rotationVector;
	}

	public virtual void Move(Vector3 translationVector)
	{
		Pivot.Translation += translationVector;
	}
}
