using System.Collections.Concurrent;
using RenderEngine.Interfaces;
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

    public static RenderTask GetTask(RenderObject renderObject, Polygon polygon, MatrixBox renderMatrix, Scene scene,
        ICustomGraphics graphics)
    {
        AvailableTasksQueue.TryDequeue(out var availableTask);

        if (availableTask == null)
        {
            availableTask = new RenderTask(renderObject, polygon, renderMatrix, scene, graphics);
        }
        else
        {
            availableTask.RenderObject = renderObject;
            availableTask.Polygon = polygon;
            availableTask.MatrixBox = renderMatrix;
            availableTask.Scene = scene;
            availableTask.Graphics = graphics;
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