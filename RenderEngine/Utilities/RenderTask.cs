using RenderEngine.Models;
using RenderEngine.Utilities.Pools;

namespace RenderEngine.Utilities;

public class RenderTask
{
    public Polygon Polygon;
    public MatrixBox MatrixBox;
    public RenderObject RenderObject;

    public RenderTask(RenderObject renderObject, Polygon polygon, MatrixBox matrixBox)
    {
        Polygon = polygon;
        MatrixBox = matrixBox;
        RenderObject = renderObject;
    }

    public void Finish()
    {
        RenderTaskPool.ReturnToAvailable(this);
    }

    
}