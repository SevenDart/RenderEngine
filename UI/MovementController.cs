using System.Numerics;
using RenderEngine.Models;
using RenderEngine.Utilities;

namespace UI;

public class MovementController
{
    private Camera _camera;
    private Func<RenderObject?> _getCurrentRenderObject;

    public bool ControlCamera { get; set; } = true;
    public float MovementSpeed { get; set; } = 0.1f;
    public float MouseRotationSpeed { get; set; } = 0.1f;

    public MovementController(Camera camera, Func<RenderObject?> getCurrentRenderObject)
    {
        _camera = camera;
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

    public void MovementKeyPressed()
    {
        if (ControlCamera)
        {
            MoveObject(_camera);
        }
        else
        {
            var renderObject = _getCurrentRenderObject();
            if (renderObject == null)
                return;

            MoveObject(renderObject);
        }
    }

    public void MouseDown(Vector2 currentPoint)
    {
        _dragPosition = currentPoint;
    }

    public void MouseMove(Vector2 currentPoint)
    {
        if (!_dragPosition.HasValue)
            return;

        var delta = (currentPoint - _dragPosition.Value) * MouseRotationSpeed;

        delta.X = delta.X.ToRadian();
        delta.Y = delta.Y.ToRadian();

        if (ControlCamera)
        {
            _camera.Pivot.Rotation += new Vector3(delta, 0);
        }
        else
        {
            var renderObject = _getCurrentRenderObject();
            if (renderObject == null)
                return;

            renderObject.Pivot.Rotation += new Vector3(delta, 0);
        }

        _dragPosition = currentPoint;
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

        renderObject.Pivot.Translation += translationVector * MovementSpeed;
    }

    class DirectionState
    {
        public bool Active;
        public Vector3 Direction;
    }
}