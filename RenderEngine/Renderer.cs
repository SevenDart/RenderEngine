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

			foreach (var renderObject in _scene.RenderObjects)
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
			
			RenderTaskPool.WaitUntilAllFinished();
			_graphics.Render();
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
		
		var facingRatio = Math.Max(0, Vector3.Dot(polygonNormal, viewVector));

		_graphics.FillPolygon(vertexProjections, Color.FromArgb(255, (int)(facingRatio * 255.0f), 0, 0));

		VectorArrayPool.ReturnToAvailable(vertexProjections);
		renderTask.Finish();
	}
}
