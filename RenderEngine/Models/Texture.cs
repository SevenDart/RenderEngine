using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class Texture
{
    private CustomBitmap _map;

    private readonly TextureType _textureType;
    private readonly WrappingType _wrappingType;

    public Texture(string filepath, TextureType textureType, WrappingType wrappingType)
    {
        _textureType = textureType;
        _wrappingType = wrappingType;
        _map = new CustomBitmap(filepath);
    }

    public Vector3 this[float x, float y]
    {
        get
        {
            x = WrapCoordinate(x);
            y = WrapCoordinate(y);
            
            var color = _map[x, (1 - y)];
            return InterpretColor(color);
        }
    }

    private Vector3 InterpretColor(Color color)
    {
        switch (_textureType)
        {
            case TextureType.Diffusion:
                return new Vector3(
                    color.R,
                    color.G,
                    color.B
                );
            
            case TextureType.Normal:
                return new Vector3(
                    (color.R / 255.0f) * 2 - 1,
                    (color.G / 255.0f) * 2 - 1,
                    (color.B / 255.0f) * 2 - 1
                );
            
            case TextureType.Reflection:
                return new Vector3(
                    color.R / 255.0f,
                    color.G / 255.0f,
                    color.B / 255.0f
                );
        }

        return Vector3.Zero;
    }

    private float WrapCoordinate(float x)
    {
        switch (_wrappingType)
        {
            case WrappingType.Repeat:
                return x % 1;
            case WrappingType.MirrorRepeat:
                return 1 - (x % 1);
            case WrappingType.Edging:
                return Math.Max(0, Math.Min(x, 1));
        }

        return 0;
    }
}

public enum TextureType
{
    Diffusion,
    Normal,
    Reflection
}

public enum WrappingType
{
    Repeat,
    MirrorRepeat,
    Edging,
    Bordering
}