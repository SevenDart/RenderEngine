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
			var renderTask = RenderTaskPool.GetTask(renderObject, polygon, finalTransformationMatrix, _scene, _graphics);
			//renderTask.DrawPolygon();
			ThreadPool.QueueUserWorkItem(renderTask.DrawPolygon);
		}
	}
}
