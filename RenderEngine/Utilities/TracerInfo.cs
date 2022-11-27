using System.Numerics;
using RenderEngine.Models;

namespace RenderEngine.Utilities;

public class TracerInfo
{
    public Vector4 ProjectedPoint;
    public Polygon Polygon;

    public TracerInfo(Vector4 projectedPoint, Polygon polygon)
    {
        ProjectedPoint = projectedPoint;
        Polygon = polygon;
    }
}