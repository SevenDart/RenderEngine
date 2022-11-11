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
			if (float.IsNaN(vertexProjections[i].X) || float.IsNaN(vertexProjections[i].Y))
			{
				VectorArrayPool.ReturnToAvailable(vertexProjections);
				renderTask.Finish();
				return;
			}
		}

		_graphics.FillPolygon(vertexProjections, Color.FromArgb(255, _random.Next(255), _random.Next(255), _random.Next(255)));

		// for (var i = 1; i < renderTask.Polygon.Vertices.Count; i++)
		// {
		// 	if (!float.IsNaN(vertexProjections[i].X) && !float.IsNaN(vertexProjections[i - 1].X))
		// 		_graphics.DrawLine(vertexProjections[i], vertexProjections[i - 1], Color.Black);
		// }
		//
		// if (!float.IsNaN(vertexProjections[^1].X) && !float.IsNaN(vertexProjections[0].X))
		// 	_graphics.DrawLine(vertexProjections[^1], vertexProjections[0], Color.Black);
		
		VectorArrayPool.ReturnToAvailable(vertexProjections);
		renderTask.Finish();
	}
}
