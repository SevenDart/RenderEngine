using System.Numerics;
using RenderEngine.Models;

namespace UI;

public class KeyboardController
{
    public float Speed { get; set; } = 1;

    public readonly string SupportedChars = "wsadWS";
    
    private readonly Dictionary<char, Vector3> _keysMap = new()
    {
        {'w', new Vector3(0, 0, 1)},
        {'s', new Vector3(0, 0, -1)},
        {'a', new Vector3(-1, 0, 0)},
        {'d', new Vector3(1, 0, 0)},
        {'W', new Vector3(0, 1, 0)},
        {'S', new Vector3(0, -1, 0)}
    };

    public void MoveObject(char keyPressed, RenderObject renderObject)
    {
        var directionVector = _keysMap[keyPressed];

        renderObject.Pivot.Translation += directionVector * Speed;
    }
}