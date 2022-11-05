using System.Numerics;
using RenderEngine.Models;

namespace RenderEngine.Utilities;

public static class RenderTaskPool
{
    public static int TaskCount = 0;
    private static readonly Queue<RenderTask> AvailableTasksQueue;
    
    private static object _listLock = new();

    static RenderTaskPool()
    {
        AvailableTasksQueue = new Queue<RenderTask>(8196);
    }

    public static RenderTask GetTask(Polygon polygon, TransformationMatrixBox renderMatrix)
    {
        RenderTask? availableTask;
        lock (_listLock)
        {
            AvailableTasksQueue.TryDequeue(out availableTask);
        }

        if (availableTask == null)
        {
            availableTask = new RenderTask(polygon, renderMatrix);
        }
        else
        {
            availableTask.Polygon = polygon;
            availableTask.MatrixBox = renderMatrix;
        }

        Interlocked.Increment(ref TaskCount);
        return availableTask;
    }

    public static void ReturnToAvailable(RenderTask renderTask)
    {
        lock (_listLock)
        {
            AvailableTasksQueue.Enqueue(renderTask);
        }
        Interlocked.Decrement(ref TaskCount);
    }
    
    public static void WaitUntilAllFinished()
    {
        while (TaskCount > 0)
        {
            Thread.Yield();
        }
    }
}