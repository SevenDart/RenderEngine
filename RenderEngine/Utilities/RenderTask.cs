using System.Drawing;
using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;
using RenderEngine.Utilities.Pools;

namespace RenderEngine.Utilities;

public class RenderTask
{
    public Polygon Polygon { get; set; }
    public MatrixBox MatrixBox { get; set; }
    public RenderObject RenderObject { get; set; }
    public Scene Scene { get; set; }
    public ICustomGraphics Graphics { get; set; }

    private Vector3[] _vertexProjections = null!;
    private float _triangleArea;
    
    public RenderTask(RenderObject renderObject, Polygon polygon, MatrixBox matrixBox, Scene scene, ICustomGraphics graphics)
    {
        Polygon = polygon;
        MatrixBox = matrixBox;
        Scene = scene;
        Graphics = graphics;
        RenderObject = renderObject;
    }
    
    public void DrawPolygon(object? state)
    {
        _vertexProjections = VectorArrayPool.GetVectorArray(3);

        for (var i = 0; i < Polygon.Vertices.Count; i++)
        {
            _vertexProjections[i] = Scene.Camera.GetScreenPointProjection(Polygon.Vertices[i].Coordinates, MatrixBox.Matrix);
            if (float.IsNaN(_vertexProjections[i].X) || float.IsNaN(_vertexProjections[i].Y) || float.IsNaN(_vertexProjections[i].Z))
            {
                Finish();
                return;
            }
        }

        FillPolygon();
        
        Finish();
    }

    private void FillPolygon()
    {
        var minX = float.MaxValue; 
        var minY = float.MaxValue;
        var maxX = float.MinValue;
        var maxY = float.MinValue;
        for (int i = 0; i < _vertexProjections.Length; i++)
        {
            minX = Math.Min(_vertexProjections[i].X, minX);
            minY = Math.Min(_vertexProjections[i].Y, minY);
            maxX = Math.Max(_vertexProjections[i].X, maxX);
            maxY = Math.Max(_vertexProjections[i].Y, maxY);
        }

        minX = Math.Max(0, (int)Math.Ceiling(minX));
        minY = Math.Max(0, (int)Math.Ceiling(minY));
        maxX = Math.Min(Scene.Camera.ScreenWidth, (int)Math.Floor(maxX));
        maxY = Math.Min(Scene.Camera.ScreenHeight, (int)Math.Floor(maxY));

        _triangleArea = GetBarycentricCoordinate(_vertexProjections[0], _vertexProjections[1], _vertexProjections[2]);
        
        for (int i = (int)minX; i <= maxX; i++)
        {
            for (int j = (int)minY; j <= maxY; j++)
            {
                DrawPoint(new Vector3(i, j, 0));
            }
        }
    }

    private void DrawPoint(Vector3 point)
    {
        var bc = GetBarycentricCoordinates(_vertexProjections, _triangleArea, point);
        point.Z = 1 / (bc.X / _vertexProjections[0].Z + bc.Y / _vertexProjections[1].Z + bc.Z / _vertexProjections[2].Z);

        if (bc.X < 0 || bc.Y < 0 || bc.Z < 0)
        {
            return;
        }

        var polygonPoint = bc.Y * Polygon.Vertices[0].Coordinates +
                    bc.Z * Polygon.Vertices[1].Coordinates +
                    bc.X * Polygon.Vertices[2].Coordinates;

        var pointNormal = GetPointNormal(bc);

        pointNormal = Vector3.TransformNormal(pointNormal, RenderObject.TransformationMatrix.Matrix);

        var cameraTransformedPoint =
            Vector3.Transform(Vector3.Zero, Scene.Camera.TransformationMatrix.Matrix);

        var polygonTransformedPoint =
            Vector3.Transform(polygonPoint, RenderObject.TransformationMatrix.Matrix);
		
        var viewVector = Vector3.Normalize(cameraTransformedPoint - polygonTransformedPoint);
		
        var facingRatio = Vector3.Dot(pointNormal, viewVector);
        
        facingRatio = Math.Max(0, facingRatio);

        var pointColor = GetPointColor(bc);

        var reflectionCoefficient = GetReflectionCoefficient(bc);
        
        var lightColor =
            Scene.LightSource.CalculateColorOfPoint(pointNormal, polygonTransformedPoint, cameraTransformedPoint, pointColor, reflectionCoefficient);

        Graphics.DrawPoint(point, Color.FromArgb(255,
            (int)(facingRatio * lightColor.R),
            (int)(facingRatio * lightColor.G),
            (int)(facingRatio * lightColor.B)
            ));
    }

    private static Vector3 GetBarycentricCoordinates(Vector3[] vertexProjections, float triangleArea, Vector3 currentPoint)
    {
        var bc = new Vector3()
        {
            X = GetBarycentricCoordinate(vertexProjections[0], vertexProjections[1], currentPoint),
            Y = GetBarycentricCoordinate(vertexProjections[1], vertexProjections[2], currentPoint),
            Z = GetBarycentricCoordinate(vertexProjections[2], vertexProjections[0], currentPoint)
        };
        bc /= triangleArea;

        return bc;
    }
    
    private static float GetBarycentricCoordinate(Vector3 point1, Vector3 point2, Vector3 currentPoint)
    {
        return (currentPoint.X - point1.X) * (point2.Y - point1.Y) - (currentPoint.Y - point1.Y) * (point2.X - point1.X);
    }

    private void Finish()
    {
        VectorArrayPool.ReturnToAvailable(_vertexProjections);
        RenderTaskPool.ReturnToAvailable(this);
    }

    private Color GetPointColor(Vector3 bc)
    {
        var textureCoordinates = GetTextureCoordinates(bc);
        
        if (RenderObject.DiffuseTexture != null 
            && textureCoordinates.HasValue)
        {
            var color = RenderObject.DiffuseTexture[textureCoordinates.Value.X, textureCoordinates.Value.Y];
            return Color.FromArgb(255,
                (int)color.X,
                (int)color.Y,
                (int)color.Z);
        }

        return RenderObject.BaseColor;
    }

    private float? GetReflectionCoefficient(Vector3 bc)
    {
        var textureCoordinates = GetTextureCoordinates(bc);

        var coefficient = RenderObject.ReflectionsTexture?[textureCoordinates.Value.X, textureCoordinates.Value.Y];

        return coefficient?.X;
    }

    private Vector3 GetPointNormal(Vector3 bc)
    {
        Vector3 pointNormal;

        var textureCoordinates = GetTextureCoordinates(bc);
        
        if (RenderObject.NormalsTexture != null 
            && textureCoordinates.HasValue)
        {
            pointNormal = RenderObject.NormalsTexture[textureCoordinates.Value.X, textureCoordinates.Value.Y];
        }
        else if (!Polygon.Vertices[0].NormalVector.HasValue ||
                 !Polygon.Vertices[1].NormalVector.HasValue ||
                 !Polygon.Vertices[2].NormalVector.HasValue)
        {
            pointNormal = Polygon.GetNormalVector(RenderObject.TransformationMatrix);
        }
        else
        {
            pointNormal = bc.Y * Polygon.Vertices[0].NormalVector!.Value +
                          bc.Z * Polygon.Vertices[1].NormalVector!.Value +
                          bc.X * Polygon.Vertices[2].NormalVector!.Value;
        }

        return Vector3.Normalize(pointNormal);
    }

    private Vector3? GetTextureCoordinates(Vector3 bc)
    {
        if (!Polygon.Vertices[0].TextureCoordinates.HasValue
            || !Polygon.Vertices[1].TextureCoordinates.HasValue
            || !Polygon.Vertices[2].TextureCoordinates.HasValue)
        {
            return null;
        }
        
        return bc.Y * Polygon.Vertices[0].TextureCoordinates +
               bc.Z * Polygon.Vertices[1].TextureCoordinates +
               bc.X * Polygon.Vertices[2].TextureCoordinates;
    }
}