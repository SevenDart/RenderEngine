using System.Numerics;

namespace RenderEngine.Models;

public class Camera: RenderObject
{
    public int ScreenWidth { get; set; }
	public int ScreenHeight { get; set; }
	public float NearPlane { get; set; }
	public float FarPlane { get; set; }
	public float FieldOfView { get; set; }

	private const float AspectRatio = 16.0f / 9;

	public Camera(Vector3 position)
    {
        Pivot = new Pivot { Translation = position };
    }

	public Vector2 ScreenProjection(Vector3 vertex, Pivot objectPivot)
    {
	    var viewportMatrix = GetToScreenMatrix();
	    var projectionMatrix = GetScreenProjectionMatrix();
	    var viewMatrix = Pivot.CreateCameraMatrix();
	    var modelMatrix = objectPivot.CreateModelMatrix();
	    
	    var resultMatrix = modelMatrix * viewMatrix * projectionMatrix * viewportMatrix;
	    
        var projection = Vector4.Transform(vertex, resultMatrix);

        return new Vector2(projection.X / projection.W, projection.Y / projection.W);
    }

	public Vector2 ApplyTransformation(Vector3 vertex, Matrix4x4 matrix)
	{
		var projection = Vector4.Transform(vertex, matrix);

		return new Vector2(projection.X / projection.W, projection.Y / projection.W);
	}

	public Matrix4x4 GetFinalTransformationMatrix(Pivot objectPivot)
	{
		var modelMatrix = objectPivot.CreateModelMatrix();
		var viewMatrix = Pivot.CreateCameraMatrix();
		var projectionMatrix = GetScreenProjectionMatrix();
		var viewportMatrix = GetToScreenMatrix();

		return modelMatrix * viewMatrix * projectionMatrix * viewportMatrix;
	}

    private Matrix4x4 GetToScreenMatrix()
    {
	    return new Matrix4x4(
		    (ScreenWidth / 2.0f), 0, 0, 0,
		    0, (-ScreenHeight / 2.0f), 0, 0,
		    0, 0, 1, 0,
		    ScreenWidth / 2.0f, ScreenHeight / 2.0f, 0, 1
	    );
    }
    
    private Matrix4x4 GetScreenProjectionMatrix()
    {
	    return Matrix4x4.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);
    }
}