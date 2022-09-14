using System.Numerics;

namespace RenderEngine.Models;

public class Camera: RenderObject
{
    public int ScreenWidth { get; set; }
	public int ScreenHeight { get; set; }

	public float ScreenDistance { get; set; }

    public float ViewAngle { get; set; }

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

		var delta = (ScreenDistance / localCoordinates.Z) * ScreenWidth 
		            / (float)(2 * ScreenDistance * Math.Tan(ViewAngle * Math.PI / 360));

		var projection = new Vector2(localCoordinates.X, localCoordinates.Y) * delta;
        
        projection = ToScreenCoordinates(projection);
        if (projection.X > 0 && projection.X < ScreenWidth 
            && projection.Y > 0 && projection.Y < ScreenHeight)
        {
            return projection;
        }

        return new Vector2(float.NaN, float.NaN);
	}

    private Vector2 ToScreenCoordinates(Vector2 v)
	{
		v += new Vector2(ScreenWidth / 2.0f, -ScreenHeight / 2.0f);
        return v with { Y = -v.Y };
	}
}