using System.Numerics;

namespace Renderer.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Vector3 Position { get; set; }
	public Vector3 Scale { get; set; }
	public Vector3 Rotation { get; set; }
}
