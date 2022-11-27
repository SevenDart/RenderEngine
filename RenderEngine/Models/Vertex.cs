﻿using System.Numerics;

namespace RenderEngine.Models;

public class Vertex
{
	public int Index { get; set; }
	public Vector3 Coordinates { get; set; }
	public float WCoordinate { get; set; } = 1;
}
