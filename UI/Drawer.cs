using System.Numerics;
using RenderEngine.Interfaces;

namespace UI;

public class Drawer: IDrawer
{
    private readonly Pen _pen;
    private BufferedGraphics? _bufferedGraphics;

    private readonly Func<BufferedGraphics> _allocateBufferedGraphics;

    public Drawer(Func<BufferedGraphics> allocateBufferedGraphics)
    {
        _allocateBufferedGraphics = allocateBufferedGraphics;
        _pen = new Pen(Color.Black);
    }

    public void Begin()
    {
        _bufferedGraphics = _allocateBufferedGraphics();
    }

    public void DrawLine(Vector2 point1, Vector2 point2)
    {
        _bufferedGraphics!.Graphics.DrawLine(_pen, point1.X, point1.Y, point2.X, point2.Y);
    }

    public void Clear()
    {
        _bufferedGraphics!.Graphics.Clear(Color.White);
    }

    public void End()
    {
        _bufferedGraphics!.Render();
        _bufferedGraphics.Dispose();
    }
}