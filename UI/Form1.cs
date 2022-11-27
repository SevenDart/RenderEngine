using System.Numerics;
using RenderEngine;
using RenderEngine.Interfaces;
using RenderEngine.Models;
using RenderEngine.Utilities;

namespace UI;

public partial class Form1 : Form
{
    private readonly Scene _scene;
    private readonly Renderer _renderer;
    private readonly IFileParser _fileParser;
    private readonly MovementController _movementController;

    public Form1()
    {
        InitializeComponent();

        _scene = new Scene
        {
            Camera =
            {
                ScreenWidth = DrawField.Width,
                ScreenHeight = DrawField.Height,
                Pivot =
                {
                    Translation = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value),
                    Rotation = new Vector3(((float)CameraYaw.Value).ToRadian(), ((float)CameraPitch.Value).ToRadian(),
                        ((float)CameraRoll.Value).ToRadian()),
                },
                NearPlane = (float)NearPlaneDist.Value,
                FarPlane = (float)FarPlaneDist.Value,
                FieldOfView = ((float)CameraFoV.Value).ToRadian()
            },
            LightSource =
            {
                Pivot =
                {
                    Translation = new Vector3((float)LightPositionX.Value, (float)LightPositionY.Value, (float)LightPositionZ.Value),
                    Rotation = new Vector3(((float)LightColorR.Value).ToRadian(), ((float)LightColorG.Value).ToRadian(),
                        ((float)LightColorB.Value).ToRadian()),
                },
                AmbientCoefficient = (float)AmbientCoefficientControl.Value,
                DiffuseCoefficient = (float)DiffuseCoefficientControl.Value,
                ReflectCoefficient = (float)ReflectCoefficientControl.Value,
                GlitterCoefficient = (float)GlitterCoefficientControl.Value
            }
        };

        _fileParser = new ObjFileParser();
        _movementController = new MovementController(_scene, GetCurrentSelectedRenderObject);
        var drawer = new Drawer(() =>
            BufferedGraphicsManager.Current.Allocate(DrawField.CreateGraphics(), DrawField.DisplayRectangle),
            DrawField.Width, DrawField.Height);

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
        _scene.Camera.NearPlane = (float)NearPlaneDist.Value;
        _scene.Camera.FarPlane = (float)FarPlaneDist.Value;
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
        UpdateCurrentObjectControls();
    }
    
    private void SetLightSettings_Click(object sender, EventArgs e)
    {
        _scene.LightSource.Pivot.Translation = new Vector3(
            (float)LightPositionX.Value,
            (float)LightPositionY.Value,
            (float)LightPositionZ.Value);

        _scene.LightSource.LightColor = Color.FromArgb(255,
            (int)LightColorR.Value, 
            (int)LightColorG.Value, 
            (int)LightColorB.Value);

        _scene.LightSource.Intensity = (float)LightIntensity.Value;

        _scene.LightSource.AmbientCoefficient = (float)AmbientCoefficientControl.Value;
        _scene.LightSource.DiffuseCoefficient = (float)DiffuseCoefficientControl.Value;
        _scene.LightSource.ReflectCoefficient = (float)ReflectCoefficientControl.Value;
        _scene.LightSource.GlitterCoefficient = (float)GlitterCoefficientControl.Value;
        
        _renderer.Render();
    }

    private void UpdateCameraControls()
    {
        CameraX.Value = (decimal)_scene.Camera.Pivot.Translation.X;
        CameraY.Value = (decimal)_scene.Camera.Pivot.Translation.Y;
        CameraZ.Value = (decimal)_scene.Camera.Pivot.Translation.Z;

        CameraYaw.Value = (decimal)(_scene.Camera.Pivot.Rotation.X.ToDegree() % 360);
        CameraPitch.Value = (decimal)(_scene.Camera.Pivot.Rotation.Y.ToDegree() % 360);
        CameraRoll.Value = (decimal)(_scene.Camera.Pivot.Rotation.Z.ToDegree() % 360);
    }

    private void UpdateCurrentObjectControls()
    {
        var renderObject = GetCurrentSelectedRenderObject();
        if (renderObject == null)
            return;

        CurrentObjX.Value = (decimal)renderObject.Pivot.Translation.X;
        CurrentObjY.Value = (decimal)renderObject.Pivot.Translation.Y;
        CurrentObjZ.Value = (decimal)renderObject.Pivot.Translation.Z;

        CurrentObjectYaw.Value = (decimal)(renderObject.Pivot.Rotation.X.ToDegree() % 360);
        CurrentObjectPitch.Value = (decimal)(renderObject.Pivot.Rotation.Y.ToDegree() % 360);
        CurrentObjectRoll.Value = (decimal)(renderObject.Pivot.Rotation.Z.ToDegree() % 360);

        ObjectScaleX.Value = (decimal)renderObject.Pivot.Scale.X;
        ObjectScaleY.Value = (decimal)renderObject.Pivot.Scale.Y;
        ObjectScaleZ.Value = (decimal)renderObject.Pivot.Scale.Z;
    }
    
    private void UpdateLightControls()
    {
        LightPositionX.Value = (decimal)_scene.LightSource.Pivot.Translation.X;
        LightPositionY.Value = (decimal)_scene.LightSource.Pivot.Translation.Y;
        LightPositionZ.Value = (decimal)_scene.LightSource.Pivot.Translation.Z;
    }

    private void UseObjectRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _movementController.MovingType = MovingType.Object;
    }

    private void UseCameraRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _movementController.MovingType = MovingType.Camera;
    }
    
    private void UseLightRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _movementController.MovingType = MovingType.LightSource;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (_movementController.AccessibleKeys.Contains(e.KeyData))
            _movementController.MovementKeyDown(e.KeyData);
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        if (_movementController.AccessibleKeys.Contains(e.KeyData))
            _movementController.MovementKeyUp(e.KeyData);
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!_movementController.AccessibleKeyChars.Contains(e.KeyChar))
            return;

        if (!_movementController.MovementKeyPressed())
            return;

        UpdateCameraControls();
        UpdateCurrentObjectControls();
        UpdateLightControls();
        
        _renderer.Render();
    }

    private void SetMovementSpeed(object sender, EventArgs e)
    {
        _movementController.MovementSpeed = (float)MovementSpeedControl.Value;
        _movementController.MouseRotationSpeed = (float)MouseSpeedControl.Value;
    }

    private void DrawField_MouseUp(object sender, MouseEventArgs e)
    {
        _movementController.MouseUp();
    }

    private void DrawField_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            var tracerInfo = RenderTask.TracerInfoBuffer![e.X, e.Y];
            debugInfo.Text = $"Point: {tracerInfo.ProjectedPoint.ToString()}\n" +
                             $"Vertex[0].TexCoordinates: {tracerInfo.Polygon.TextureCoordinates[0]}\n" +
                             $"Vertex[1].TexCoordinates: {tracerInfo.Polygon.TextureCoordinates[1]}\n" +
                             $"Vertex[2].TexCoordinates: {tracerInfo.Polygon.TextureCoordinates[2]}\n";
        }
        else
        {
            debugInfo.Text = "";
        }

        _movementController.MouseDown(new Vector2(e.X, e.Y));
    }

    private void DrawField_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_movementController.MouseMove(new Vector2(e.X, e.Y))) 
            return;
        
        UpdateCurrentObjectControls();
        UpdateCameraControls();
        _renderer.Render();
    }

    private RenderObject? GetCurrentSelectedRenderObject()
    {
        if (RenderObjectsList.Items.Count == 0 || RenderObjectsList.SelectedIndex == -1)
            return null;

        return _scene.RenderObjects.First(r => r.Name == RenderObjectsList.SelectedItem.ToString());
    }

    private void ChooseColorButton_Click(object sender, EventArgs e)
    {
        SetObjectColorDialog.ShowDialog();

        var renderObject = GetCurrentSelectedRenderObject();

        if (renderObject != null)
        {
            renderObject.BaseColor = SetObjectColorDialog.Color;
        }
        
        _renderer.Render();
    }
}