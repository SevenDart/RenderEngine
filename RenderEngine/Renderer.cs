using RenderEngine.Interfaces;
using RenderEngine.Models;
using RenderEngine.Utilities;

namespace RenderEngine;

public class Renderer
{
	private readonly IDrawer _drawer;
	private readonly Scene _scene;
	private ICustomGraphics _graphics = null!;
	private Logger _logger = new Logger();

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
				var matrixBox = new TransformationMatrixBox(_scene.Camera.GetFinalTransformationMatrix(renderObject.Pivot));
				
				foreach (var polygon in renderObject.Polygons)
				{
					var renderTask = RenderTaskPool.GetTask(polygon, matrixBox);
					ThreadPool.QueueUserWorkItem(DrawPolygon, renderTask, true);
				}
			}
			
			RenderTaskPool.WaitUntilAllFinished();
			_graphics.Render();
		}
	}

	private void DrawPolygon(RenderTask renderTask)
	{
		var firstVertexProjection =
			_scene.Camera.GetScreenPointProjection(renderTask.Polygon.Vertices[0].Coordinates, renderTask.MatrixBox.Matrix);

		var previousProjection = firstVertexProjection;

		for (var i = 1; i < renderTask.Polygon.Vertices.Count; i++)
		{
			var vertexProjection =
				_scene.Camera.GetScreenPointProjection(renderTask.Polygon.Vertices[i].Coordinates, renderTask.MatrixBox.Matrix);

			if (!float.IsNaN(vertexProjection.X) && !float.IsNaN(previousProjection.X))
				_graphics.DrawLine(previousProjection, vertexProjection);

			previousProjection = vertexProjection;
		}

		if (!float.IsNaN(firstVertexProjection.X) && !float.IsNaN(previousProjection.X))
			_graphics.DrawLine(previousProjection, firstVertexProjection);
		
		renderTask.Finish();
	}
}
