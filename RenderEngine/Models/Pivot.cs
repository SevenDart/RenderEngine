using System.Numerics;

namespace RenderEngine.Models;

public class Pivot
{
    public Vector3 Translation { get; set; }
    public Vector3 Rotation { get; set; } = new(0, 0, 0);
    public Vector3 Scale { get; set; } = new(1, 1, 1);

    public Matrix4x4 CreateModelMatrix()
    {
        var scaleMatrix = Matrix4x4.CreateScale(Scale);
        var rotationMatrix = Matrix4x4.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z);
        var translationMatrix = Matrix4x4.CreateTranslation(Translation);
        return scaleMatrix * rotationMatrix * translationMatrix;
    }

    public Matrix4x4 CreateCameraMatrix()
    {
        var rotationMatrix = Matrix4x4.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z);
        var translationMatrix = Matrix4x4.CreateTranslation(Translation);
        return translationMatrix * rotationMatrix;
    }
}