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
			var transformationMatrix = _scene.Camera.GetFinalTransformationMatrix(renderObject.Pivot);
			
			foreach (var polygon in renderObject.Polygons)
			{
				DrawPolygon(polygon, transformationMatrix);
			}
		}
		
		_drawer.End();
	}

	private void DrawPolygon(Polygon polygon, Matrix4x4 transformationMatrix)
	{
		var previousProjection = 
			_scene.Camera.ApplyTransformation(polygon.Vertices[0].Coordinates, transformationMatrix);
		
		for (var i = 1; i < polygon.Vertices.Count; i++)
		{
			var vertexProjection =
				_scene.Camera.ApplyTransformation(polygon.Vertices[i].Coordinates, transformationMatrix);
			
			_drawer.DrawLine(previousProjection, vertexProjection);

			previousProjection = vertexProjection;
		}
		
		var firstVertexProjection = 
			_scene.Camera.ApplyTransformation(polygon.Vertices[0].Coordinates, transformationMatrix);
		
		_drawer.DrawLine(previousProjection, firstVertexProjection);
	}
}
