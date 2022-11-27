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

    private Vector4[] _vertexProjections = null!;
    private float _triangleArea;

    public static TracerInfo[,]? TracerInfoBuffer;
    
    public RenderTask(RenderObject renderObject, Polygon polygon, MatrixBox matrixBox, Scene scene, ICustomGraphics graphics)
    {
        Polygon = polygon;
        MatrixBox = matrixBox;
        Scene = scene;
        Graphics = graphics;
        RenderObject = renderObject;
        if (TracerInfoBuffer == null)
        {
            TracerInfoBuffer = new TracerInfo[scene.Camera.ScreenWidth, scene.Camera.ScreenHeight];
            
            for (int i = 0; i < scene.Camera.ScreenWidth; i++)
            for (int j = 0; j < scene.Camera.ScreenHeight; j++)
                TracerInfoBuffer[i, j] = new TracerInfo(new Vector4(), null);
        }
    }
    
    public void DrawPolygon(object? state)
    {
        _vertexProjections = VectorArrayPool.GetVector4Array(3);

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

        /*for (int i = 0; i < _vertexProjections.Length; i++)
        {
            var v1 = new Vector3(_vertexProjections[i].X, _vertexProjections[i].Y, _vertexProjections[i].Z - 0.01f);
            var v2 = new Vector3(_vertexProjections[(i + 1) % 3].X, _vertexProjections[(i + 1) % 3].Y, _vertexProjections[(i + 1) % 3].Z - 0.01f);
            Graphics.DrawLine(v1, v2, Color.Black);
        }*/
        
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
                DrawPoint(new Vector4(i, j, 0, 0));
            }
        }
    }

    private void DrawPoint(Vector4 point)
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

        var textureCoordinates = GetTextureCoordinates(bc);

        var pointNormal = GetPointNormal(bc, textureCoordinates);

        pointNormal = Vector3.TransformNormal(pointNormal, RenderObject.TransformationMatrix.Matrix);

        var cameraTransformedPoint =
            Vector3.Transform(Vector3.Zero, Scene.Camera.TransformationMatrix.Matrix);

        var polygonTransformedPoint =
            Vector3.Transform(polygonPoint, RenderObject.TransformationMatrix.Matrix);
		
        var viewVector = Vector3.Normalize(cameraTransformedPoint - polygonTransformedPoint);
		
        var facingRatio = Vector3.Dot(pointNormal, viewVector);

        if (facingRatio <= 0)
        {
            return;
        }
        
        facingRatio = Math.Max(0, facingRatio);

        var pointColor = GetPointColor(textureCoordinates);

        var reflectionCoefficient = GetReflectionCoefficient(textureCoordinates);
        
        var lightColor =
            Scene.LightSource.CalculateColorOfPoint(pointNormal, polygonTransformedPoint, cameraTransformedPoint, pointColor, reflectionCoefficient);

        var endPoint = new Vector3(point.X, point.Y, point.Z);
        
        var result = Graphics.DrawPoint(endPoint, Color.FromArgb(255,
            (int)Math.Max(0, Math.Min(facingRatio * lightColor.R, 255)),
            (int)Math.Max(0,Math.Min(facingRatio * lightColor.G, 255)),
            (int)Math.Max(0,Math.Min(facingRatio * lightColor.B, 255))
        ));

        if (result)
        {
            TracerInfoBuffer![(int)endPoint.X, (int)endPoint.Y].ProjectedPoint = point;
            TracerInfoBuffer![(int)endPoint.X, (int)endPoint.Y].Polygon = Polygon;
        }
    }

    private static Vector3 GetBarycentricCoordinates(Vector4[] vertexProjections, float triangleArea, Vector4 currentPoint)
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
    
    private static float GetBarycentricCoordinate(Vector4 point1, Vector4 point2, Vector4 currentPoint)
    {
        return (currentPoint.X - point1.X) * (point2.Y - point1.Y) - (currentPoint.Y - point1.Y) * (point2.X - point1.X);
    }

    private void Finish()
    {
        VectorArrayPool.ReturnToAvailable(_vertexProjections);
        RenderTaskPool.ReturnToAvailable(this);
    }

    private Color GetPointColor(Vector3? textureCoordinates)
    {
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

    private float? GetReflectionCoefficient(Vector3? textureCoordinates)
    {
        var coefficient = RenderObject.ReflectionsTexture?[textureCoordinates.Value.X, textureCoordinates.Value.Y];

        return coefficient?.X;
    }

    private Vector3 GetPointNormal(Vector3 bc, Vector3? textureCoordinates)
    {
        Vector3 pointNormal;

        if (RenderObject.NormalsTexture != null 
            && textureCoordinates.HasValue)
        {
            pointNormal = RenderObject.NormalsTexture[textureCoordinates.Value.X, textureCoordinates.Value.Y];
        }
        else if (Polygon.NormalVectors.Count != 3 
                   || !Polygon.NormalVectors[0].HasValue 
                   || !Polygon.NormalVectors[1].HasValue 
                   || !Polygon.NormalVectors[2].HasValue)
        {
            pointNormal = Polygon.GetNormalVector(RenderObject.TransformationMatrix);
        }
        else
        {
            pointNormal = bc.Y * Polygon.NormalVectors[0].Value +
                          bc.Z * Polygon.NormalVectors[1].Value +
                          bc.X * Polygon.NormalVectors[2].Value;
        }

        return Vector3.Normalize(pointNormal);
    }

    private Vector3? GetTextureCoordinates(Vector3 bc)
    {
        if (Polygon.TextureCoordinates.Count != 3 
            || !Polygon.TextureCoordinates[0].HasValue
            || !Polygon.TextureCoordinates[1].HasValue
            || !Polygon.TextureCoordinates[2].HasValue)
        {
            return null;
        }

        var coordinates = (bc.Y * Polygon.TextureCoordinates[0] / _vertexProjections[0].W ) +
                          (bc.Z * Polygon.TextureCoordinates[1] / _vertexProjections[1].W ) +
                          (bc.X * Polygon.TextureCoordinates[2] / _vertexProjections[2].W );
        
        coordinates /= ((bc.Y / _vertexProjections[0].W) +
                       (bc.Z / _vertexProjections[1].W) +
                       (bc.X / _vertexProjections[2].W));

        return coordinates;
    }
}