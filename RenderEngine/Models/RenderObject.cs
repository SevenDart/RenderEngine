namespace RenderEngine.Models;

public class RenderObject
{
	public string Name { get; set; } = null!;
	public List<Polygon> Polygons { get; set; } = new();
	public Pivot Pivot { get; set; } = null!;
}
