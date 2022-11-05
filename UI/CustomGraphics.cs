using System.Numerics;
using RenderEngine.Interfaces;

namespace UI;

public class CustomGraphics : ICustomGraphics
{
    private readonly CustomBitmap _bitmap;
    private readonly BufferedGraphics _bufferedGraphics;

    public CustomGraphics(int width, int height, BufferedGraphics bufferedGraphics)
    {
        _bufferedGraphics = bufferedGraphics;
        Clear();
        _bitmap = new CustomBitmap(width, height);
    }
    
    public void DrawLine(Vector2 point1, Vector2 point2)
    {
        var delta = point2 - point1;
        var stepsCount = Math.Max(Math.Abs(delta.X), Math.Abs(delta.Y));

        var currentPoint = point1;
        delta /= stepsCount;

        for (int i = 0; i < stepsCount; i++)
        {
            _bitmap[currentPoint.X, currentPoint.Y] = Color.Black;
            currentPoint += delta;
        }
    }

    public void Clear()
    {
        _bufferedGraphics.Graphics.Clear(Color.White);
    }

    public void Render()
    {
        var bitmap = _bitmap.GetResultBitmap();
        _bufferedGraphics.Graphics.DrawImage(bitmap, Point.Empty);
        
        _bufferedGraphics.Render();
    }

    public void Dispose()
    {
        _bitmap.Dispose();
        _bufferedGraphics.Dispose();
    }
}