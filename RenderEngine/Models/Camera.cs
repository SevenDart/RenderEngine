using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class Camera: RenderObject
{
    public int ScreenWidth { get; set; }
	public int ScreenHeight { get; set; }
	public float NearPlane { get; set; }
	public float FarPlane { get; set; }
	public float FieldOfView { get; set; }
	
	public Vector3 GlobalCoordinates { get; set; }

	private float AspectRatio => (float)ScreenWidth / ScreenHeight;

	public Camera()
	{
		Pivot = new Pivot();
	}
	
	public override void RefreshTransformationMatrix()
	{
		var newModelMatrix = Pivot.CreateModelMatrix();
		
		if (newModelMatrix == TransformationMatrix.Matrix)
			return;

		TransformationMatrix.Matrix = newModelMatrix;

		GlobalCoordinates = Vector3.Transform(Vector3.Zero, newModelMatrix);
	}

	public Vector4 GetScreenPointProjection(Vector3 vertex, Matrix4x4 matrix)
	{
		var projection = Vector4.Transform(vertex, matrix);

		if (projection.Z < NearPlane || projection.Z > FarPlane)
			return new Vector4(float.NaN);


		projection.X /= projection.W;
		projection.Y /= projection.W;
		projection.Z /= projection.W;
		
		return projection;
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

    public override void Move(Vector3 translationVector)
    {
	    var cameraRotation = Matrix4x4.CreateFromYawPitchRoll(Pivot.Rotation.X,
		    Pivot.Rotation.Y, Pivot.Rotation.Z);
	    translationVector = Vector3.Transform(translationVector, cameraRotation); 
	    
	    base.Move(translationVector);
    }
}