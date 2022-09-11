using System.Numerics;

namespace Renderer.Models;

public class Camera: RenderObject
{
    public int ScreenWidth { get; set; } = 1024;
	public int ScreenHeight { get; set; } = 720;

	public float ScreenDistance { get; set; } = 200;

    public float ViewAngle { get; set; } = 90;

    public Camera(Vector3 position)
    {
        Pivot = new Pivot()
        {
            Center = position
		};
    }

    public Vector2 ScreenProjection(Vector3 vertex)
    {
        var localCoordinates = Pivot.ToLocalCoords(vertex);

        if (localCoordinates.Z < ScreenDistance)
        {
			return new Vector2(float.NaN, float.NaN);
		}

		var delta = (ScreenDistance / localCoordinates.Z) * ScreenWidth / (float)(2 * ScreenDistance * Math.Tan(ViewAngle / 2));

		var projection = new Vector2(localCoordinates.X, localCoordinates.Y) * delta;
        
        projection = ToScreenCoordinates(projection);
        if (projection.X > 0 && projection.X < ScreenWidth 
            && projection.Y > 0 && projection.Y < ScreenHeight)
        {
            return projection;
        }

        return new Vector2(float.NaN, float.NaN);
	}

	public Vector2 ToScreenCoordinates(Vector2 v)
	{
		v += new Vector2(ScreenWidth / 2, ScreenHeight / 2);
        return new Vector2(v.X, -v.Y);
	}
}