using System.Numerics;

namespace RenderEngine.Utilities;

public class TransformationMatrixBox
{
    public readonly Matrix4x4 Matrix;

    public TransformationMatrixBox(Matrix4x4 matrix)
    {
        Matrix = matrix;
    }
}