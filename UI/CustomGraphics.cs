using System.Numerics;
using RenderEngine.Interfaces;

namespace UI;

public class CustomGraphics : ICustomGraphics
{
    private readonly CustomBitmap _bitmap;
    private readonly BufferedGraphics _bufferedGraphics;

    private readonly int _width;
    private readonly int _height;

    public CustomGraphics(int width, int height, BufferedGraphics bufferedGraphics)
    {
        _width = width;
        _height = height;
        _bufferedGraphics = bufferedGraphics;
        Clear();
        _bitmap = new CustomBitmap(width, height);
    }
    
    public void DrawLine(Vector2 point1, Vector2 point2)
    {
        if ((point1.Y < 0 && point2.Y < 0) 
            || (point1.Y > _height && point2.Y > _height) 
            || (point1.X < 0 && point2.X < 0) 
            || (point1.X > _width && point2.X > _width))
        {
            return;
        }
        
        var delta = point2 - point1;
        var stepsCount = Math.Max(Math.Abs(delta.X), Math.Abs(delta.Y));

        var currentPoint = point1;
        delta /= stepsCount;

        for (int i = 0; i < stepsCount; i++)
        {
            if (!(currentPoint.X < 0 || currentPoint.Y < 0 || currentPoint.X > _width || currentPoint.Y > _height))
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