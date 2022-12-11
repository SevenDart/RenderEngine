using System.Drawing;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class LightSource : RenderObject
{
    public Color LightColor { get; set; } = Color.White;
    public float Intensity { get; set; } = 1;
    public float AmbientCoefficient { get; set; } = 0.01f;
    public float DiffuseCoefficient { get; set; } = 0.18f;
    public Vector3 SpecularCoefficient { get; set; } = new(0.5f);
    public float GlitterCoefficient { get; set; } = 50;
    private Vector3 _globalCoordinates;
    
    public LightSource()
    {
        Pivot = new Pivot();
        var objParser = new ObjFileParser();
        var task = Task.Run(() => objParser.ParseFile(@"D:\CODE\ACG\Objects\light_sphere.obj"));
        task.Wait();
        Polygons = task.Result.First().Polygons;
        BaseColor = Color.Yellow;
        Pivot.Scale = new Vector3(0.1f);
    }
    
    public override void RefreshTransformationMatrix()
    {
        var newModelMatrix = Pivot.CreateModelMatrix();
		
        if (newModelMatrix == TransformationMatrix.Matrix)
            return;

        TransformationMatrix.Matrix = newModelMatrix;

        _globalCoordinates = Vector3.Transform(Vector3.Zero, newModelMatrix);
    }
    
    public Color CalculateColorOfPoint(Vector3 pointNormal,
        Vector3 point,
        Vector3 cameraPoint,
        Color baseColor,
        Vector3? specularCoefficient, 
        float? specularExponent)
    {
        var ambient = CalculateAmbient(baseColor);
        var diffuse = CalculateDiffuse(pointNormal, point, baseColor);
        var reflection = CalculateReflect(pointNormal, 
            point, 
            cameraPoint, 
            specularCoefficient ?? SpecularCoefficient, 
            specularExponent ?? GlitterCoefficient);

        var resultColor = Color.FromArgb(255,
            Math.Min(ambient.R + diffuse.R + reflection.R, 255),
            Math.Min(ambient.G + diffuse.G + reflection.G, 255),
            Math.Min(ambient.B + diffuse.B + reflection.B, 255)
            );

        return resultColor;
    }

    private Color CalculateAmbient(Color baseColor)
    {
        return Color.FromArgb(255,
            (int)(baseColor.R * AmbientCoefficient), 
            (int)(baseColor.G * AmbientCoefficient), 
            (int)(baseColor.B * AmbientCoefficient)
            );
    }

    private Color CalculateDiffuse(Vector3 pointNormal, Vector3 point, Color baseColor)
    {
        var lightDirection = Vector3.Normalize(_globalCoordinates - point);
        
        var distanceSquared = Vector3.DistanceSquared(_globalCoordinates, point);
        
        var angle = Vector3.Dot(lightDirection, pointNormal);

        var lightStrength = Math.Max(0, angle) * Intensity / (Math.Max(0.01, distanceSquared));

        var resultColor = Color.FromArgb(255,
            (int)Math.Max(0, Math.Min(255, LightColor.R * lightStrength * baseColor.R)),
            (int)Math.Max(0, Math.Min(255, LightColor.G * lightStrength * baseColor.G)),
            (int)Math.Max(0, Math.Min(255, LightColor.B * lightStrength * baseColor.B))
        );

        return resultColor;
    }

    private Color CalculateReflect(Vector3 pointNormal, 
        Vector3 point, 
        Vector3 cameraPoint, 
        Vector3 specularCoefficient,
        float specularExponent)
    {
        var lightDirection = Vector3.Normalize(-_globalCoordinates + point);

        var reflectedVector = Vector3.Normalize(Vector3.Reflect(lightDirection, pointNormal));

        var viewVector = Vector3.Normalize(cameraPoint - point);

        var reflectStrength =
            Math.Pow(Math.Max(0, Vector3.Dot(viewVector, reflectedVector)), specularExponent);

        var resultColor = Color.FromArgb(255,
            (int)Math.Min(LightColor.R * reflectStrength * specularCoefficient.X, 255),
            (int)Math.Min(LightColor.G * reflectStrength * specularCoefficient.Y, 255),
            (int)Math.Min(LightColor.B * reflectStrength * specularCoefficient.Z, 255)
        );

        return resultColor;
    }
}