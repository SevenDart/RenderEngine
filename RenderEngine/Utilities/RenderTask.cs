using RenderEngine.Models;
using RenderEngine.Utilities.Pools;

namespace RenderEngine.Utilities;

public class RenderTask
{
    public Polygon Polygon;
    public MatrixBox MatrixBox;

    public RenderTask(Polygon polygon, MatrixBox matrixBox)
    {
        Polygon = polygon;
        MatrixBox = matrixBox;
    }

    public void Finish()
    {
        RenderTaskPool.ReturnToAvailable(this);
    }

    
}