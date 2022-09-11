namespace Renderer.Models;

public class Scene
{
    public List<RenderObject> RenderObjects { get; set; } = new();
    public Camera Camera { get; set; } = null!;
}