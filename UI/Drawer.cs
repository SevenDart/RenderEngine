using RenderEngine.Interfaces;

namespace UI;

public class Drawer: IDrawer
{
    private readonly Func<BufferedGraphics> _allocateBufferedGraphics;
    
    private readonly int _width;
    private readonly int _height;

    public Drawer(Func<BufferedGraphics> allocateBufferedGraphics, int width, int height)
    {
        _allocateBufferedGraphics = allocateBufferedGraphics;
        _width = width;
        _height = height;
    }

    public ICustomGraphics GetGraphics()
    {
        return new CustomGraphics(_width, _height, _allocateBufferedGraphics());
    }
}