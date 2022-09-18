using System.Numerics;
using System.Text.RegularExpressions;
using RenderEngine;
using RenderEngine.Models;
using RenderEngine.Utilities;
using RenderEngine.Utilities.Implementations;

namespace UI;

public partial class Form1 : Form
{
    private readonly Scene _scene;
    private readonly Renderer _renderer;
    private readonly IFileParser _fileParser;
    private readonly KeyboardController _keyboardController;

    private bool _useCamera = true;

    public Form1()
    {
        InitializeComponent();

        _fileParser = new ObjFileParser();
        _keyboardController = new KeyboardController();

        _scene = new Scene
        {
            Camera =
            {
                ScreenWidth = DrawField.Width,
                ScreenHeight = DrawField.Height,
                Pivot =
                {
                    Translation = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value)
                },
                NearPlane = 1 / (float)CameraScreenDist.Value,
                FarPlane = (float)CameraScreenDist.Value,
                FieldOfView = ((float)CameraFoV.Value).ToRadian()
            }
        };

        var drawer = new Drawer(() => 
            BufferedGraphicsManager.Current.Allocate(DrawField.CreateGraphics(), DrawField.DisplayRectangle));
         
        _renderer = new Renderer(_scene, drawer);
    }

    private void SetObjectSettingsButton_Click(object sender, EventArgs e)
    {
        var renderObject = GetCurrentSelectedRenderObject();
        if (renderObject == null)
            return;

        renderObject.Pivot.Translation = new Vector3((float)CurrentObjX.Value, (float)CurrentObjY.Value, (float)CurrentObjZ.Value);

        renderObject.Pivot.Rotation = new Vector3(
            ((float)CurrentObjectYaw.Value).ToRadian(),
            ((float)CurrentObjectPitch.Value).ToRadian(),
            ((float)CurrentObjectRoll.Value).ToRadian());

        renderObject.Pivot.Scale = new Vector3(
            (float)ObjectScaleX.Value,
            (float)ObjectScaleY.Value,
            (float)ObjectScaleZ.Value);
        
        _renderer.Render();
    }

    private void SetCameraSettings(object sender, EventArgs e)
    {
        _scene.Camera.Pivot.Translation = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value);
        _scene.Camera.NearPlane = 1 / (float)CameraScreenDist.Value;
        _scene.Camera.FarPlane = (float)CameraScreenDist.Value;
        _scene.Camera.FieldOfView = ((float)CameraFoV.Value).ToRadian();

        _scene.Camera.Pivot.Rotation = new Vector3(
            ((float)CameraYaw.Value).ToRadian(),
            ((float)CameraPitch.Value).ToRadian(),
            ((float)CameraRoll.Value).ToRadian()
        );

        _renderer.Render();
    }

    private void RemoveObjectButton_Click(object sender, EventArgs e)
    {
        var renderObject = GetCurrentSelectedRenderObject();
        if (renderObject == null)
            return;
        
        _scene.RenderObjects.Remove(renderObject);

        RenderObjectsList.Items.Remove(renderObject.Name);

        if (RenderObjectsList.Items.Count != 0)
            RenderObjectsList.SetSelected(0, true);
        
        _renderer.Render();
    }

    private async void AddObjectButton_Click(object sender, EventArgs e)
    {
        if (OpenObjFileDialog.ShowDialog() != DialogResult.OK)
            return;

        var path = OpenObjFileDialog.FileName;
        var renderObject = await _fileParser.ParseFile(path);

        //TODO fix adding prefix to dups
        if (RenderObjectsList.Items.Contains(renderObject.Name))
        {
            renderObject.Name += '*';
        }

        _scene.RenderObjects.Add(renderObject);

        RenderObjectsList.Items.Add(renderObject.Name);
        RenderObjectsList.SetSelected(RenderObjectsList.Items.Count - 1, true);

        _renderer.Render();
    }

    private void RenderObjectsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        var renderObject = GetCurrentSelectedRenderObject();
        if (renderObject == null)
            return;

        CurrentObjX.Value = (decimal)renderObject.Pivot.Translation.X;
        CurrentObjY.Value = (decimal)renderObject.Pivot.Translation.Y;
        CurrentObjZ.Value = (decimal)renderObject.Pivot.Translation.Z;

        CurrentObjectYaw.Value = (decimal)renderObject.Pivot.Rotation.X;
        CurrentObjectPitch.Value = (decimal)renderObject.Pivot.Rotation.Y;
        CurrentObjectRoll.Value = (decimal)renderObject.Pivot.Rotation.Z;

        ObjectScaleX.Value = (decimal)renderObject.Pivot.Scale.X;
        ObjectScaleY.Value = (decimal)renderObject.Pivot.Scale.Y;
        ObjectScaleZ.Value = (decimal)renderObject.Pivot.Scale.Z;
    }

    private void UseObjectRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _useCamera = !UseObjectRadioButton.Checked;
    }

    private void UseCameraRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _useCamera = UseCameraRadioButton.Checked;
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Regex.IsMatch(e.KeyChar.ToString(), $"[{_keyboardController.SupportedChars}]"))
        {
            return;
        }

        if (_useCamera)
        {
            _keyboardController.MoveObject(e.KeyChar, _scene.Camera);
            UpdateCameraControls();
        }
        else
        {
            var renderObject = GetCurrentSelectedRenderObject();
            if (renderObject == null)
                return;
            
            _keyboardController.MoveObject(e.KeyChar, renderObject);
            UpdateCurrentObjectControls();
        }
        
        _renderer.Render();
    }

    private void MovementSpeedControl_ValueChanged(object sender, EventArgs e)
    {
        _keyboardController.Speed = (float)MovementSpeedControl.Value;
    }

    private void UpdateCameraControls()
    {
        CameraX.Value = (decimal)_scene.Camera.Pivot.Translation.X;
        CameraY.Value = (decimal)_scene.Camera.Pivot.Translation.Y;
        CameraZ.Value = (decimal)_scene.Camera.Pivot.Translation.Z;

        CameraYaw.Value = (decimal)_scene.Camera.Pivot.Rotation.X.ToDegree();
        CameraPitch.Value = (decimal)_scene.Camera.Pivot.Rotation.Y.ToDegree();
        CameraRoll.Value = (decimal)_scene.Camera.Pivot.Rotation.Z.ToDegree();
    }
    
    private void UpdateCurrentObjectControls()
    {
        var renderObject = GetCurrentSelectedRenderObject();
        if (renderObject == null)
            return;
        
        CurrentObjX.Value = (decimal)renderObject.Pivot.Translation.X;
        CurrentObjY.Value = (decimal)renderObject.Pivot.Translation.Y;
        CurrentObjZ.Value = (decimal)renderObject.Pivot.Translation.Z;
        
        CurrentObjectYaw.Value = (decimal)renderObject.Pivot.Rotation.X.ToDegree();
        CurrentObjectPitch.Value = (decimal)renderObject.Pivot.Rotation.Y.ToDegree();
        CurrentObjectRoll.Value = (decimal)renderObject.Pivot.Rotation.Z.ToDegree();
    }

    private Vector2? _dragPosition;

    private void DrawField_MouseUp(object sender, MouseEventArgs e)
    {
        _dragPosition = null;
    }

    private void DrawField_MouseDown(object sender, MouseEventArgs e)
    {
        _dragPosition = new Vector2(e.X, e.Y);
    }

    private void DrawField_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_dragPosition.HasValue) 
            return;

        var currentPosition = new Vector2(e.X, e.Y);
        var delta = (currentPosition - _dragPosition.Value) * _keyboardController.Speed;

        delta.X = delta.X.ToRadian();
        delta.Y = delta.Y.ToRadian();
        
        if (_useCamera)
        {
            _scene.Camera.Pivot.Rotation += new Vector3(delta, 0);
            UpdateCameraControls();
        }
        else
        {
            var renderObject = GetCurrentSelectedRenderObject();
            if (renderObject == null)
                return;

            renderObject.Pivot.Rotation += new Vector3(delta, 0);
            UpdateCurrentObjectControls();
        }

        _dragPosition = currentPosition;
        _renderer.Render();
    }

    private RenderObject? GetCurrentSelectedRenderObject()
    {
        if (RenderObjectsList.Items.Count == 0)
            return null;

        if (RenderObjectsList.SelectedIndex == -1)
        {
            RenderObjectsList.SelectedIndex = 0;
        }
        
        return _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());
    }
}