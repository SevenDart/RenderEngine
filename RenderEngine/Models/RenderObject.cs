using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Pivot Pivot { get; set; } = null!;

	public MatrixBox TransformationMatrix { get; set; } = null!;

	public virtual void RefreshTransformationMatrix()
	{
		TransformationMatrix = new MatrixBox(Pivot.CreateModelMatrix());
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
