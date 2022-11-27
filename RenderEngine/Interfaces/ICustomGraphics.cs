using System.Drawing;
using System.Numerics;
using RenderEngine.Models;

namespace RenderEngine.Interfaces;

public interface ICustomGraphics: IDisposable
{
    void FillPolygon(Vector3[] vertexProjections, Color color);
    bool DrawPoint(Vector3 point, Color color);
    void DrawLine(Vector3 point1, Vector3 point2, Color color);
    void Render();
}