using System.Drawing;
using System.Numerics;
using RenderEngine.Utilities;

namespace RenderEngine.Models;

public class Texture
{
    private readonly CustomBitmap _map;

    private readonly TextureType _textureType;
    private readonly WrappingType _wrappingType = WrappingType.Repeat;

    public Texture(string filepath, TextureType textureType)
    {
        _textureType = textureType;
        _map = new CustomBitmap(filepath);
    }

    public Vector3 this[float x, float y]
    {
        get
        {
            x = WrapCoordinate(x);
            y = WrapCoordinate(y);
            
            var color = _map[x, 1 - y];
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
                return Vector3.Normalize(new Vector3(
                    color.R - 127.5f,
                    color.G - 127.5f,
                    color.B - 127.5f
                ));
            
            case TextureType.Specular:
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
                return x <= 1 ? x : x % 1;
            case WrappingType.MirrorRepeat:
                return x <= 1 
                    ? x
                    : 1 - (x % 1);
            case WrappingType.Edging:
                return Math.Max(0, Math.Min(x, 1));
        }

        return x <= 1 ? x : 0;
    }
}

public enum TextureType
{
    Diffusion,
    Normal,
    Specular
}

public enum WrappingType
{
    Repeat,
    MirrorRepeat,
    Edging,
    Bordering
}