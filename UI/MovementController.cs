using System.Numerics;
using RenderEngine.Models;
using RenderEngine.Utilities;

namespace UI;

public class MovementController
{
    private Scene _scene;
    private Func<RenderObject?> _getCurrentRenderObject;

    public MovingType MovingType { get; set; }
    public float MovementSpeed { get; set; } = 0.1f;
    public float MouseRotationSpeed { get; set; } = 0.1f;

    public MovementController(Scene scene, Func<RenderObject?> getCurrentRenderObject)
    {
        _scene = scene;
        _getCurrentRenderObject = getCurrentRenderObject;
    }

    private readonly Dictionary<Keys, DirectionState> _keysDirectionsMap = new()
    {
        { Keys.W, new DirectionState { Direction = new Vector3(0, 0, 1) } },
        { Keys.S, new DirectionState { Direction = new Vector3(0, 0, -1) } },
        { Keys.A, new DirectionState { Direction = new Vector3(-1, 0, 0) } },
        { Keys.D, new DirectionState { Direction = new Vector3(1, 0, 0) } },
        { Keys.W | Keys.Shift, new DirectionState { Direction = new Vector3(0, 1, 0) } },
        { Keys.S | Keys.Shift, new DirectionState { Direction = new Vector3(0, -1, 0) } }
    };

    private Vector2? _dragPosition = null;

    public IEnumerable<Keys> AccessibleKeys => _keysDirectionsMap.Keys;

    public IEnumerable<char> AccessibleKeyChars
    {
        get
        {
            var keysConverter = new KeysConverter();
            return AccessibleKeys.Select(k => keysConverter.ConvertToString(value: k)!.ToLower()[0]);
        }
    }

    public void MovementKeyDown(Keys key)
    {
        var directionState = _keysDirectionsMap[key];
        directionState.Active = true;
    }

    public void MovementKeyUp(Keys key)
    {
        var directionState = _keysDirectionsMap[key];
        directionState.Active = false;
    }

    public bool MovementKeyPressed()
    {
        switch (MovingType)
        {
            case MovingType.Camera:
                MoveObject(_scene.Camera);
                break;
            case MovingType.LightSource:
                MoveObject(_scene.LightSource);
                break;
            case MovingType.Object:
                var renderObject = _getCurrentRenderObject();
                if (renderObject == null)
                    return false;

                MoveObject(renderObject);
                break;
        }

        return true;
    }

    public void MouseDown(Vector2 currentPoint)
    {
        _dragPosition = currentPoint;
    }

    public bool MouseMove(Vector2 currentPoint)
    {
        if (MovingType == MovingType.LightSource)
        {
            return false;
        }
        
        if (!_dragPosition.HasValue)
            return false;

        var delta = (currentPoint - _dragPosition.Value) * MouseRotationSpeed;

        delta.X = delta.X.ToRadian();
        delta.Y = delta.Y.ToRadian();
        
        var rotationObject = MovingType == MovingType.Camera ? _scene.Camera : _getCurrentRenderObject();

        if (rotationObject == null)
        {
            return false;
        }

        rotationObject.Rotate(new Vector3(delta, 0));
        _dragPosition = currentPoint;
        return true;
    }

    public void MouseUp()
    {
        _dragPosition = null;
    }

    private void MoveObject(RenderObject renderObject)
    {
        var translationVector = _keysDirectionsMap.Values
            .Where(ds => ds.Active)
            .Aggregate(Vector3.Zero,
                (current, directionState) => current + directionState.Direction);

        renderObject.Move(translationVector * MovementSpeed);
    }

    class DirectionState
    {
        public bool Active;
        public Vector3 Direction;
    }
}