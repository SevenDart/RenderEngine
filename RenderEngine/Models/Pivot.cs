using System.Numerics;

namespace RenderEngine.Models;

public class Pivot
{
    public Vector3 Translation { get; set; } = Vector3.Zero;
    public Vector3 Rotation { get; set; } = Vector3.Zero;
    public Vector3 Scale { get; set; } = Vector3.One;

    public Matrix4x4 CreateModelMatrix()
    {
        var scaleMatrix = Matrix4x4.CreateScale(Scale);
        var rotationMatrix = Matrix4x4.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z);
        var translationMatrix = Matrix4x4.CreateTranslation(Translation.X, Translation.Y, -Translation.Z);
        return scaleMatrix * rotationMatrix * translationMatrix;
    }

    public Matrix4x4 CreateCameraMatrix()
    {
        var rotationMatrix = Matrix4x4.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z);
        var translationMatrix = Matrix4x4.CreateTranslation(-Translation.X, -Translation.Y, Translation.Z);
        return translationMatrix * rotationMatrix;
    }
}