using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;

namespace RenderEngine;

public class Renderer
{
	private readonly IDrawer _drawer;
	private readonly Scene _scene;
	
	public Renderer(Scene scene, IDrawer drawer)
	{
		_scene = scene;
		_drawer = drawer;
	}

	public void Render()
	{
		_drawer.Begin();
		_drawer.Clear();
		foreach (var renderObject in _scene.RenderObjects)
		{
			foreach (var polygon in renderObject.Polygons)
			{
				DrawPolygon(renderObject.Pivot, polygon);
			}
		}
		_drawer.End();
	}

	private void DrawPolygon(Pivot pivot, Polygon polygon)
	{
		var previousProjection = _scene.Camera
			.ScreenProjection(pivot.ToGlobalCoords(polygon.Vertices[0].Coordinates));
		for (var i = 1; i < polygon.Vertices.Count; i++)
		{
			var vertexProjection = _scene.Camera
				.ScreenProjection(pivot.ToGlobalCoords(polygon.Vertices[i].Coordinates));

			if (!float.IsNaN(vertexProjection.X) 
			    && !float.IsNaN(vertexProjection.Y) 
			    && !float.IsNaN(previousProjection.X) 
			    && !float.IsNaN(previousProjection.Y))
				_drawer.DrawLine(previousProjection, vertexProjection);

			previousProjection = vertexProjection;
		}
		var firstVertexProjection = _scene.Camera
			.ScreenProjection(pivot.ToGlobalCoords(polygon.Vertices[0].Coordinates));

		if (!float.IsNaN(firstVertexProjection.X) 
		    && !float.IsNaN(firstVertexProjection.Y) 
		    && !float.IsNaN(previousProjection.X) 
		    && !float.IsNaN(previousProjection.Y))
			_drawer.DrawLine(previousProjection, firstVertexProjection);
	}
}
