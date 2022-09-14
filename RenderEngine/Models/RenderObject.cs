using System.Numerics;

namespace RenderEngine.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Pivot Pivot { get; set; } = null!;

	public void Move(Vector3 v)
	{
		Pivot.Move(v);
	}

	public void Rotate(Vector3 rotationAngles)
	{
		Pivot.Rotate(rotationAngles);
	}
}
