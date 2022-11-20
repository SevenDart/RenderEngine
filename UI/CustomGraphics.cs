using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;
using RenderEngine.Utilities.Pools;

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

        minY = Math.Max(0, (int)Math.Ceiling(minY));
        maxY = Math.Min(_height, (int)Math.Floor(maxY));

        var triangleArea = GetBarycentricCoordinate(vertexProjections[0], vertexProjections[1], vertexProjections[2]);
        
        for (int y = (int)minY; y <= maxY; y++)
        {
            GetTriangleIntersection(vertexProjections, y, minX, maxX, out var startPoint, out var endPoint);
            
            if (!float.IsNaN(startPoint.X) && !float.IsNaN(endPoint.X))
            {
                startPoint.X = (float)Math.Floor(startPoint.X);
                startPoint.Z = GetDepthOfProjection(vertexProjections, GetBarycentricCoordinates(vertexProjections, triangleArea, startPoint));
                
                endPoint.Z = GetDepthOfProjection(vertexProjections, GetBarycentricCoordinates(vertexProjections, triangleArea, endPoint));

                DrawLine(startPoint, endPoint, color);
            }
        }
    }

    public void DrawPoint(Vector3 point, Color color)
    {
        if (point.X < 0 || point.Y < 0 || point.X >= _width || point.Y >= _height) 
            return;

        if (point.Z <= _depthBuffer![(int)Math.Floor(point.X), (int)Math.Floor(point.Y)])
        {
            _depthBuffer[(int)Math.Floor(point.X), (int)Math.Floor(point.Y)] = point.Z;
            _bitmap[point.X, point.Y] = color;
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

    private void GetTriangleIntersection(Vector3[] vertexProjections, int yLevel,
        float minX, float maxX,
        out Vector3 startPoint, out Vector3 endPoint)
    {
        var intersections = VectorArrayPool.GetVectorArray(3);

        var int1 = new Vector3(float.NaN);
        var int2 = new Vector3(float.NaN);

        for (int i = 0; i < vertexProjections.Length; i++)
        {
            intersections[i] = GetLineIntersection(vertexProjections[i], vertexProjections[(i + 1) % 3], yLevel);

            if (!float.IsNaN(intersections[i].X) && intersections[i].X >= minX && intersections[i].X <= maxX 
                && (intersections[i].X >= Math.Min(vertexProjections[i].X, vertexProjections[(i + 1) % 3].X))
                && (intersections[i].X <= Math.Max(vertexProjections[i].X, vertexProjections[(i + 1) % 3].X))
                && (intersections[i].Y >= Math.Min(vertexProjections[i].Y, vertexProjections[(i + 1) % 3].Y))
                && (intersections[i].Y <= Math.Max(vertexProjections[i].Y, vertexProjections[(i + 1) % 3].Y)))
            {
                if (float.IsNaN(int1.X))
                {
                    int1 = intersections[i];
                }
                else
                {
                    int2 = intersections[i];
                }
            }
        }

        startPoint = int1;
        endPoint = int2;

        if (float.IsNaN(endPoint.X) && !float.IsNaN(startPoint.X))
        {
            endPoint = startPoint;
        }
        
        VectorArrayPool.ReturnToAvailable(intersections);
    }

    private Vector3 GetLineIntersection(Vector3 point1, Vector3 point2, int yLevel)
    {
        var a = (point1.Y - point2.Y) /
                (point1.X - point2.X);

        if (float.IsNaN(a))
        {
            return new Vector3(point1.X, yLevel, 0);
        }

        if (a == 0 && Math.Abs(point1.Y - yLevel) <= float.Epsilon)
        {
            return new Vector3(point2.X, yLevel, 0);
        } 
        
        var b = point1.Y - a * point1.X;
        
        var x = (yLevel - b) / a;

        return new Vector3(x, yLevel, 0);
    }

    private float GetDepthOfProjection(Vector3[] vertexProjections, Vector3 barycentricCoords)
    {
        return 1 / (barycentricCoords.X / vertexProjections[0].Z + 
                    barycentricCoords.Y / vertexProjections[1].Z + 
                    barycentricCoords.Z / vertexProjections[2].Z);
    }

    private Vector3 GetBarycentricCoordinates(Vector3[] vertices, float triangleArea, Vector3 currentPoint)
    {
        var bc = new Vector3
        {
            X = GetBarycentricCoordinate(vertices[0], vertices[1], currentPoint),
            Y = GetBarycentricCoordinate(vertices[1], vertices[2], currentPoint),
            Z = GetBarycentricCoordinate(vertices[2], vertices[0], currentPoint)
        };

        return bc / triangleArea;
    }
    
    private float GetBarycentricCoordinate(Vector3 point1, Vector3 point2, Vector3 currentPoint)
    {
        return (currentPoint.X - point1.X) * (point2.Y - point1.Y) - (currentPoint.Y - point1.Y) * (point2.X - point1.X);
    }
}