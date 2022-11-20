using System.Drawing;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class LightSource : RenderObject
{
    public Color LightColor { get; set; } = Color.White;
    public float Intensity { get; set; } = 1;
    
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


    public Color CalculateColorOfPoint(Vector3 pointNormal, Vector3 point, Color baseColor)
    {
        var lightColorPoint = Vector3.Transform(Vector3.Zero, TransformationMatrix.Matrix);
        var lightDirection = Vector3.Normalize(lightColorPoint - point);
        var distanceSquared = Vector3.DistanceSquared(lightColorPoint, point);
        
        var angle = Vector3.Dot(lightDirection, pointNormal);

        var lightStrength = Math.Max(0.01f, angle) * Intensity / (4 * Math.PI * distanceSquared);

        var resultColor = Color.FromArgb(255,
            (int)Math.Max(0, Math.Min(255, LightColor.R * lightStrength * baseColor.R)),
            (int)Math.Max(0, Math.Min(255, LightColor.G * lightStrength * baseColor.G)),
            (int)Math.Max(0, Math.Min(255, LightColor.B * lightStrength * baseColor.B))
        );

        return resultColor;
    }
}