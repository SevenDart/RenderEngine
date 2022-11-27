using System.Collections.Concurrent;
using System.Numerics;

namespace RenderEngine.Utilities.Pools;

public static class VectorArrayPool
{
    private static readonly ConcurrentDictionary<int, ConcurrentQueue<Vector3[]>> Vector3ArraysDictionary;
    private static readonly ConcurrentDictionary<int, ConcurrentQueue<Vector4[]>> Vector4ArraysDictionary;

    static VectorArrayPool()
    {
        Vector3ArraysDictionary = new ConcurrentDictionary<int, ConcurrentQueue<Vector3[]>>();
        Vector4ArraysDictionary = new ConcurrentDictionary<int, ConcurrentQueue<Vector4[]>>();
        for (int i = 0; i < 10; i++)
        {
            Vector3ArraysDictionary[i] = new ConcurrentQueue<Vector3[]>();
            Vector4ArraysDictionary[i] = new ConcurrentQueue<Vector4[]>();
        }
    }

    public static Vector3[] GetVector3Array(int length)
    {
        Vector3ArraysDictionary[length].TryDequeue(out var availableArray);

        availableArray ??= new Vector3[length];
        
        return availableArray;
    }
    
    public static Vector4[] GetVector4Array(int length)
    {
        Vector4ArraysDictionary[length].TryDequeue(out var availableArray);

        availableArray ??= new Vector4[length];
        
        return availableArray;
    }

    public static void ReturnToAvailable(Vector3[] array)
    {
        Vector3ArraysDictionary[array.Length].Enqueue(array);
    }
    
    public static void ReturnToAvailable(Vector4[] array)
    {
        Vector4ArraysDictionary[array.Length].Enqueue(array);
    }
}