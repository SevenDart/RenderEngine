using RenderEngine.Models;

namespace RenderEngine.Utilities;

public class RenderTask
{
    public Polygon Polygon;
    public TransformationMatrixBox MatrixBox;

    public RenderTask(Polygon polygon, TransformationMatrixBox matrixBox)
    {
        Polygon = polygon;
        MatrixBox = matrixBox;
    }

    public void Finish()
    {
        RenderTaskPool.ReturnToAvailable(this);
    }

    
}