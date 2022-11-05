using System.Numerics;

namespace RenderEngine.Interfaces;

public interface ICustomGraphics: IDisposable
{
    void DrawLine(Vector2 point1, Vector2 point2);
    void Render();
}