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
                    Center = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value)
                },
                ScreenDistance = 1 / (float)CameraScreenDist.Value,
                ViewAngle = (int)CameraFoV.Value
            }
        };

        var drawer = new Drawer(() => 
            BufferedGraphicsManager.Current.Allocate(DrawField.CreateGraphics(), DrawField.DisplayRectangle));
        _renderer = new Renderer(_scene, drawer);
    }

    private void SetObjectSettingsButton_Click(object sender, EventArgs e)
    {
        if (RenderObjectsList.Items.Count == 0)
            return;

        var renderObject = _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());

        renderObject.Pivot.Center = new Vector3((float)CurrentObjX.Value, (float)CurrentObjY.Value, (float)CurrentObjZ.Value);
        
        renderObject.Rotate(new Vector3(
            (float)CurrentObjLeanYZ.Value, 
            (float)CurrentObjLeanXZ.Value, 
            (float)CurrentObjLeanXY.Value));
        
        renderObject.Scale(new Vector3(
            (float)ObjectScaleX.Value, 
            (float)ObjectScaleY.Value, 
            (float)ObjectScaleZ.Value));
        
        _renderer.Render();
    }

    private void SetCameraSettings(object sender, EventArgs e)
    {
        _scene.Camera.Pivot.Center = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value);
        _scene.Camera.ScreenDistance = 1 / (float)CameraScreenDist.Value;
        _scene.Camera.ViewAngle = (int)CameraFoV.Value;
        
        _scene.Camera.Rotate(new Vector3((float)CameraLeanYZ.Value, (float)CameraLeanXZ.Value, (float)CameraLeanXY.Value));

        _renderer.Render();
    }

    private void RemoveObjectButton_Click(object sender, EventArgs e)
    {
        if (RenderObjectsList.Items.Count == 0)
            return;

        var renderObject = _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());
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
        var renderObject = _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());

        CurrentObjX.Value = (decimal)renderObject.Pivot.Center.X;
        CurrentObjY.Value = (decimal)renderObject.Pivot.Center.Y;
        CurrentObjZ.Value = (decimal)renderObject.Pivot.Center.Z;

        CurrentObjLeanYZ.Value = (decimal)renderObject.Rotation.X;
        CurrentObjLeanXZ.Value = (decimal)renderObject.Rotation.Y;
        CurrentObjLeanXY.Value = (decimal)renderObject.Rotation.Z;

        ObjectScaleX.Value = (decimal)renderObject.ScaleVector.X;
        ObjectScaleY.Value = (decimal)renderObject.ScaleVector.Y;
        ObjectScaleZ.Value = (decimal)renderObject.ScaleVector.Z;
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
            if (RenderObjectsList.Items.Count == 0)
                return;
            var renderObject = _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());
            
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
        CameraX.Value = (decimal)_scene.Camera.Pivot.Center.X;
        CameraY.Value = (decimal)_scene.Camera.Pivot.Center.Y;
        CameraZ.Value = (decimal)_scene.Camera.Pivot.Center.Z;

        CameraLeanYZ.Value = (decimal)_scene.Camera.Rotation.X;
        CameraLeanXZ.Value = (decimal)_scene.Camera.Rotation.Y;
        CameraLeanXY.Value = (decimal)_scene.Camera.Rotation.Z;
    }
    
    private void UpdateCurrentObjectControls()
    {
        var renderObject = _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());
        
        CurrentObjX.Value = (decimal)renderObject.Pivot.Center.X;
        CurrentObjY.Value = (decimal)renderObject.Pivot.Center.Y;
        CurrentObjZ.Value = (decimal)renderObject.Pivot.Center.Z;

        CurrentObjLeanYZ.Value = (decimal)renderObject.Rotation.X;
        CurrentObjLeanXZ.Value = (decimal)renderObject.Rotation.Y;
        CurrentObjLeanXY.Value = (decimal)renderObject.Rotation.Z;
    }

    private void DrawField_DragEnter(object sender, DragEventArgs e)
    {
        
    }

    private void DrawField_DragDrop(object sender, DragEventArgs e)
    {

    }
}