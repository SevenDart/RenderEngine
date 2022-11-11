using System.Collections.Concurrent;
using System.Numerics;

namespace RenderEngine.Utilities.Pools;

public static class VectorArrayPool
{
    private static readonly ConcurrentDictionary<int, ConcurrentQueue<Vector3[]>> VectorArraysDictionary;

    static VectorArrayPool()
    {
        VectorArraysDictionary = new ConcurrentDictionary<int, ConcurrentQueue<Vector3[]>>();
        for (int i = 0; i < 10; i++)
        {
            VectorArraysDictionary[i] = new ConcurrentQueue<Vector3[]>();
        }
    }

    public static Vector3[] GetVectorArray(int length)
    {
        VectorArraysDictionary[length].TryDequeue(out var availableArray);

        availableArray ??= new Vector3[length];
        
        return availableArray;
    }

    public static void ReturnToAvailable(Vector3[] array)
    {
        VectorArraysDictionary[array.Length].Enqueue(array);
    }
}