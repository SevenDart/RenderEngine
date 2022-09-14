using System.Numerics;

namespace RenderEngine.Models;

public class Scene
{
    public Scene()
    {
        Camera = new Camera(new Vector3(0, 0, -1));
    }
    
    public List<RenderObject> RenderObjects { get; set; } = new();
    public Camera Camera { get; set; } = null!;
}