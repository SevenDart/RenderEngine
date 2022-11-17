using System.Drawing;
using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;
using RenderEngine.Utilities;
using RenderEngine.Utilities.Pools;

namespace RenderEngine;

public class Renderer
{
	private readonly IDrawer _drawer;
	private readonly Scene _scene;
	private ICustomGraphics _graphics = null!;
	private Logger _logger = new Logger();

	private static Random _random = new();

	public Renderer(Scene scene, IDrawer drawer)
	{
		_scene = scene;
		_drawer = drawer;
	}

	public void Render()
	{
		using (_graphics = _drawer.GetGraphics())
		{
			_scene.Camera.RefreshTransformationMatrix();
			_scene.LightSource.RefreshTransformationMatrix();

			foreach (var renderObject in _scene.RenderObjects)
			{
				Render(renderObject);
			}
			
			Render(_scene.LightSource);
			
			RenderTaskPool.WaitUntilAllFinished();
			_graphics.Render();
		}
	}

	private void Render(RenderObject renderObject)
	{
		renderObject.RefreshTransformationMatrix();
				
		var finalTransformationMatrix = new MatrixBox(_scene.Camera.GetFinalTransformationMatrix(renderObject.Pivot));
				
		foreach (var polygon in renderObject.Polygons)
		{
			var renderTask = RenderTaskPool.GetTask(renderObject, polygon, finalTransformationMatrix);
			DrawPolygon(renderTask);
			//ThreadPool.QueueUserWorkItem(DrawPolygon, renderTask, true);
		}
	}

	private void DrawPolygon(RenderTask renderTask)
	{
		var vertexProjections = VectorArrayPool.GetVectorArray(3);

		for (var i = 0; i < renderTask.Polygon.Vertices.Count; i++)
		{
			vertexProjections[i] = _scene.Camera.GetScreenPointProjection(renderTask.Polygon.Vertices[i].Coordinates, renderTask.MatrixBox.Matrix);
			if (float.IsNaN(vertexProjections[i].X) || float.IsNaN(vertexProjections[i].Y) || float.IsNaN(vertexProjections[i].Z))
			{
				VectorArrayPool.ReturnToAvailable(vertexProjections);
				renderTask.Finish();
				return;
			}
		}

		var polygonNormal = renderTask.Polygon.GetNormalVector(renderTask.RenderObject.TransformationMatrix);

		var cameraTransformedPoint =
			Vector3.Transform(Vector3.Zero, _scene.Camera.TransformationMatrix.Matrix);

		var polygonTransformedPoint =
			Vector3.Transform(renderTask.Polygon.Vertices[0].Coordinates, renderTask.RenderObject.TransformationMatrix.Matrix);
		
		var viewVector = Vector3.Normalize(cameraTransformedPoint - polygonTransformedPoint);
		
		var facingRatio = Vector3.Dot(polygonNormal, viewVector);
		if (facingRatio < 0)
		{
			VectorArrayPool.ReturnToAvailable(vertexProjections);
			renderTask.Finish();
			return;
		}

		var lightedColor = _scene.LightSource.CalculateColorOfPolygon(polygonNormal, polygonTransformedPoint,
			renderTask.RenderObject.BaseColor);

		var resultColor = Color.FromArgb(255, 
			(int)(facingRatio * lightedColor.R),
			(int)(facingRatio * lightedColor.G),
			(int)(facingRatio * lightedColor.B));
		
		_graphics.FillPolygon(vertexProjections, resultColor);

		VectorArrayPool.ReturnToAvailable(vertexProjections);
		renderTask.Finish();
	}
}
