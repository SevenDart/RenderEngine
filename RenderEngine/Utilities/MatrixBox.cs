using System.Numerics;

namespace RenderEngine.Utilities;

public class MatrixBox
{
    public readonly Matrix4x4 Matrix;

    public MatrixBox(Matrix4x4 matrix)
    {
        Matrix = matrix;
    }
}