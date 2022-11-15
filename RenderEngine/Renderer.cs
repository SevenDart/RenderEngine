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
			foreach (var renderObject in _scene.RenderObjects)
			{
				var matrixBox = new MatrixBox(_scene.Camera.GetFinalTransformationMatrix(renderObject.Pivot));
				
				foreach (var polygon in renderObject.Polygons)
				{
					var renderTask = RenderTaskPool.GetTask(polygon, matrixBox);
					//DrawPolygon(renderTask);
					ThreadPool.QueueUserWorkItem(DrawPolygon, renderTask, true);
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

		var polygonNormal = renderTask.Polygon.GetNormalVector();

		var viewVector = Vector3.Normalize(_scene.Camera.Pivot.Translation - renderTask.Polygon.Vertices[0].Coordinates);
		
		var facingRatio = Math.Max(0, Vector3.Dot(polygonNormal, viewVector));

		_graphics.FillPolygon(vertexProjections, Color.FromArgb(255, (int)(facingRatio * 255.0f), 0, 0));

		VectorArrayPool.ReturnToAvailable(vertexProjections);
		renderTask.Finish();
	}
}
