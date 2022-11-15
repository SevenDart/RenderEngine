using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;

namespace UI;

public class CustomGraphics : ICustomGraphics
{
    private readonly CustomBitmap _bitmap;
    private readonly BufferedGraphics _bufferedGraphics;

    private readonly int _width;
    private readonly int _height;

    private static float[,]? _depthBuffer;

    public CustomGraphics(int width, int height, BufferedGraphics bufferedGraphics)
    {
        _width = width;
        _height = height;
        _bufferedGraphics = bufferedGraphics;
        Clear();
        _bitmap = new CustomBitmap(width, height);

        _depthBuffer ??= new float[_width, _height];

        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                _depthBuffer[i, j] = float.MaxValue;
            }
        }
    }

    public void FillPolygon(Vector3[] vertexProjections, Color color)
    {
        var minX = float.MaxValue; 
        var minY = float.MaxValue;
        var maxX = float.MinValue;
        var maxY = float.MinValue;
        for (int i = 0; i < vertexProjections.Length; i++)
        {
            minX = Math.Min(vertexProjections[i].X, minX);
            minY = Math.Min(vertexProjections[i].Y, minY);
            maxX = Math.Max(vertexProjections[i].X, maxX);
            maxY = Math.Max(vertexProjections[i].Y, maxY);
        }

        minX = Math.Max(0, (int)Math.Ceiling(minX));
        minY = Math.Max(0, (int)Math.Ceiling(minY));
        maxX = Math.Min(_width, (int)Math.Floor(maxX));
        maxY = Math.Min(_height, (int)Math.Floor(maxY));

        var triangleArea = GetBarycentricCoordinate(vertexProjections[0], vertexProjections[1], vertexProjections[2]);
        
        for (int i = (int)minX; i <= maxX; i++)
        {
            for (int j = (int)minY; j <= maxY; j++)
            {
                var bc = new Vector3()
                {
                    X = GetBarycentricCoordinate(vertexProjections[0], vertexProjections[1], new Vector3(i, j, 0)),
                    Y = GetBarycentricCoordinate(vertexProjections[1], vertexProjections[2], new Vector3(i, j, 0)),
                    Z = GetBarycentricCoordinate(vertexProjections[2], vertexProjections[0], new Vector3(i, j, 0))
                };
                bc /= triangleArea;
				
                var zCoord = 1 / (bc.X / vertexProjections[0].Z + bc.Y / vertexProjections[1].Z + bc.Z / vertexProjections[2].Z);

                if (bc.X >= 0 && bc.Y >= 0 && bc.Z >= 0 && bc.X <= 1 && bc.Y <= 1 && bc.Z <= 1)
                {
                    DrawPoint(new Vector3(i, j, zCoord), color);
                }
            }
        }
    }

    public void DrawPoint(Vector3 point, Color color)
    {
        if (!(point.X < 0 || point.Y < 0 || point.X >= _width || point.Y >= _height))
        {
            if (point.Z <= _depthBuffer![(int)Math.Floor(point.X), (int)Math.Floor(point.Y)])
            {
                _depthBuffer[(int)Math.Floor(point.X), (int)Math.Floor(point.Y)] = point.Z;
                _bitmap[point.X, point.Y] = color;
            }
        }
    }

    public void DrawLine(Vector3 point1, Vector3 point2, Color color)
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
            DrawPoint(currentPoint, color);
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
    
    private float GetBarycentricCoordinate(Vector3 point1, Vector3 point2, Vector3 currentPoint)
    {
        return (currentPoint.X - point1.X) * (point2.Y - point1.Y) - (currentPoint.Y - point1.Y) * (point2.X - point1.X);
    }
}