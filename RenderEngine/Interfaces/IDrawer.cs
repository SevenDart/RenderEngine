using System.Numerics;

namespace RenderEngine.Interfaces;

public interface IDrawer
{
    void DrawLine(Vector2 point1, Vector2 point2);
    void Clear();
    void Begin();
    void End();
}