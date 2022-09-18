using System.Numerics;

namespace RenderEngine.Utilities;

public static class MathExtensions
{
    public static float ToRadian(this float value)
    {
        return value * (float)Math.PI / 180;
    }

    public static float ToDegree(this float value)
    {
        return value * 180 / (float)Math.PI;
    }
}