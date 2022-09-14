using System.Numerics;

namespace RenderEngine.Models;

public class Pivot
{
    public Vector3 Center { get; set; }
    public Vector3 XAxis { get; set; } = new(1, 0, 0);
    public Vector3 YAxis { get; set; } = new(0, 1, 0);
	public Vector3 ZAxis { get; set; } = new(0, 0, 1);

	private Matrix4x4 LocalCoordsMatrix => new(
        XAxis.X, YAxis.X, ZAxis.X, 0,
        XAxis.Y, YAxis.Y, ZAxis.Y, 0,
        XAxis.Z, YAxis.Z, ZAxis.Z, 0,
        0, 0, 0, 1
    );

    private Matrix4x4 GlobalCoordsMatrix => new(
        XAxis.X , XAxis.Y , XAxis.Z, 0,
        YAxis.X , YAxis.Y , YAxis.Z, 0,
        ZAxis.X , ZAxis.Y , ZAxis.Z, 0,
        0, 0, 0, 1
    );

    public Vector3 ToLocalCoords(Vector3 global)
    {
        return Vector3.Transform(global - Center, LocalCoordsMatrix);
    }
    public Vector3 ToGlobalCoords(Vector3 local)
    {
        return Vector3.Transform(local , GlobalCoordsMatrix) + Center;
    }

    public void Move(Vector3 v)
    {
        Center += v;
    }

    public void Rotate(Vector3 rotationAngles)
    {
        //TODO
    }
}