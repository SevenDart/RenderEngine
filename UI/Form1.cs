using System.Numerics;
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

    public Form1()
    {
        InitializeComponent();

        _fileParser = new ObjFileParser();

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
        
        _renderer.Render();
    }

    private void SetCameraSettings(object sender, EventArgs e)
    {
        _scene.Camera.Pivot.Center = new Vector3((float)CameraX.Value, (float)CameraY.Value, (float)CameraZ.Value);
        _scene.Camera.ScreenDistance = 1 / (float)CameraScreenDist.Value;
        _scene.Camera.ViewAngle = (int)CameraFoV.Value;

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
}