using System.Numerics;

namespace RenderEngine.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Pivot Pivot { get; set; } = null!;

	public virtual void Move(Vector3 translationVector)
	{
		Pivot.Translation += translationVector;
	}
}
