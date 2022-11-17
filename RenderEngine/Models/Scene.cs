namespace RenderEngine.Models;

public class Scene
{
    public Scene()
    {
        Camera = new Camera();
        LightSource = new LightSource();
    }
    
    public List<RenderObject> RenderObjects { get; set; } = new();
    public Camera Camera { get; set; }
    public LightSource LightSource { get; set; }
}