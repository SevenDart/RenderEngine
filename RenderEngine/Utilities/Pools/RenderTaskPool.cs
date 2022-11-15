using System.Collections.Concurrent;
using RenderEngine.Models;

namespace RenderEngine.Utilities.Pools;

public static class RenderTaskPool
{
    public static int TaskCount = 0;
    private static readonly ConcurrentQueue<RenderTask> AvailableTasksQueue;

    static RenderTaskPool()
    {
        AvailableTasksQueue = new ConcurrentQueue<RenderTask>();
    }

    public static RenderTask GetTask(RenderObject renderObject, Polygon polygon, MatrixBox renderMatrix)
    {
        AvailableTasksQueue.TryDequeue(out var availableTask);

        if (availableTask == null)
        {
            availableTask = new RenderTask(renderObject, polygon, renderMatrix);
        }
        else
        {
            availableTask.RenderObject = renderObject;
            availableTask.Polygon = polygon;
            availableTask.MatrixBox = renderMatrix;
        }

        Interlocked.Increment(ref TaskCount);
        return availableTask;
    }

    public static void ReturnToAvailable(RenderTask renderTask)
    {
        AvailableTasksQueue.Enqueue(renderTask);
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