using System.Drawing;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class LightSource : RenderObject
{
    public Color LightColor { get; set; } = Color.White;
    public float Intensity { get; set; } = 1;

    public Color AmbientColor { get; set; } = Color.White;
    public float AmbientCoefficient { get; set; } = 0.01f;
    public float DiffuseCoefficient { get; set; } = 0.18f;
    public float ReflectCoefficient { get; set; } = 0.1f;
    public float GlitterCoefficient { get; set; } = 0.1f;
    
    public LightSource()
    {
        Pivot = new Pivot();
        var objParser = new ObjFileParser();
        var task = Task.Run(() => objParser.ParseFile(@"D:\CODE\ACG\Objects\light_sphere.obj"));
        task.Wait();
        Polygons = task.Result.Polygons;
        BaseColor = Color.Yellow;
        Pivot.Scale = new Vector3(0.1f);
    }


    public Color CalculateColorOfPoint(Vector3 pointNormal, 
        Vector3 point, 
        Vector3 cameraPoint, 
        Color baseColor,
        float? reflectionCoefficient)
    {
        var ambient = CalculateAmbient();
        var diffuse = CalculateDiffuse(pointNormal, point, baseColor);
        var reflection = CalculateReflect(pointNormal, point, cameraPoint, reflectionCoefficient ?? ReflectCoefficient);

        var resultColor = Color.FromArgb(255,
            Math.Min(ambient.R + diffuse.R + reflection.R, 255),
            Math.Min(ambient.G + diffuse.G + reflection.G, 255),
            Math.Min(ambient.B + diffuse.B + reflection.B, 255)
            );

        return resultColor;
    }

    private Color CalculateAmbient()
    {
        return Color.FromArgb(255,
            (int)(AmbientColor.R * AmbientCoefficient), 
            (int)(AmbientColor.G * AmbientCoefficient), 
            (int)(AmbientColor.B * AmbientCoefficient)
            );
    }

    private Color CalculateDiffuse(Vector3 pointNormal, Vector3 point, Color baseColor)
    {
        var lightColorPoint = Vector3.Transform(Vector3.Zero, TransformationMatrix.Matrix);
        var lightDirection = Vector3.Normalize(lightColorPoint - point);
        
        var distanceSquared = Vector3.DistanceSquared(lightColorPoint, point);
        
        var angle = Vector3.Dot(lightDirection, pointNormal);

        var lightStrength = Math.Max(0, angle) * Intensity / (4 * Math.PI * distanceSquared);

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
        float reflectionCoefficient)
    {
        var lightColorPoint = Vector3.Transform(Vector3.Zero, TransformationMatrix.Matrix);
        var lightDirection = Vector3.Normalize(-lightColorPoint + point);

        var reflectedVector = Vector3.Normalize(Vector3.Reflect(lightDirection, pointNormal));

        var viewVector = Vector3.Normalize(cameraPoint - point);

        var reflectStrength =
            Math.Pow(Math.Max(0, Vector3.Dot(viewVector, reflectedVector)), GlitterCoefficient) * reflectionCoefficient;

        var resultColor = Color.FromArgb(255,
            (int)Math.Min(LightColor.R * reflectStrength, 255),
            (int)Math.Min(LightColor.G * reflectStrength, 255),
            (int)Math.Min(LightColor.B * reflectStrength, 255)
        );

        return resultColor;
    }
}