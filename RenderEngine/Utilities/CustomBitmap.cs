using System.Drawing;
using System.Drawing.Imaging;

namespace RenderEngine.Utilities;

public class CustomBitmap : IDisposable
{
    private Bitmap _bitmap;
    private BitmapData _bitmapData;

    private int _width;
    private int _height;

    private CoordinatesType _coordinatesType;

    private Color[] _palette = Array.Empty<Color>();

    public CustomBitmap(int width, int height)
    {
        _width = width;
        _height = height;
        _coordinatesType = CoordinatesType.Real;
        _bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        
        _bitmapData = _bitmap.LockBits(new Rectangle(0, 0, width, height), 
            ImageLockMode.ReadWrite, 
            _bitmap.PixelFormat);
    }

    public CustomBitmap(string filepath)
    {
        _coordinatesType = CoordinatesType.Normalized;

        _bitmap = new Bitmap(filepath);
        _width = _bitmap.Width;
        _height = _bitmap.Height;
        _palette = _bitmap.Palette.Entries;
        
        _bitmapData = _bitmap.LockBits(new Rectangle(0, 0, _width, _height), 
            ImageLockMode.ReadOnly, 
            _bitmap.PixelFormat);
    }

    public Color this[float x, float y]
    {
        get
        {
            if (_coordinatesType == CoordinatesType.Normalized)
            {
                x = (float)Math.Round(x * _width);
                y = (float)Math.Round(y * _height);
            }

            var offset = 0;
            if (_bitmapData.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                offset = (int)(y * _width + x);
                byte color = 0;
                unsafe
                {
                    color = *(byte*)(_bitmapData.Scan0 + offset).ToPointer();
                }

                return _palette[color];
            }

            if (_bitmapData.PixelFormat == PixelFormat.Format4bppIndexed)
            {
                offset = (int)(y * _width + x);

                byte valueByte = 0;
                unsafe
                {
                    valueByte = *(byte*)(_bitmapData.Scan0 + (int)Math.Floor(offset / 2.0f)).ToPointer();
                }

                valueByte = offset % 2 == 1 
                    ? (byte)(valueByte >> 4)
                    : (byte)(valueByte & 15);

                return _palette[valueByte];
            }


            if (_bitmapData.PixelFormat == PixelFormat.Format24bppRgb)
            {
                offset = (int)(Math.Floor(y) * _width * 3 + Math.Floor(x) * 3);
                if (offset + 2 < Math.Abs(_bitmapData.Stride) * _bitmapData.Height)
                {
                    byte r, g, b, a;
                    unsafe
                    {
                        a = 255;
                        r = *(byte*)(_bitmapData.Scan0 + offset + 2).ToPointer();
                        g = *(byte*)(_bitmapData.Scan0 + offset + 1).ToPointer();
                        b = *(byte*)(_bitmapData.Scan0 + offset + 0).ToPointer();
                    }
                    return Color.FromArgb(a, r, g, b);
                }
            }

            offset = (int)(Math.Floor(y) * _width * 4 + Math.Floor(x) * 4);
            if (offset + 3 < Math.Abs(_bitmapData.Stride) * _bitmapData.Height)
            {
                byte r, g, b, a;
                unsafe
                {
                    a = *(byte*)(_bitmapData.Scan0 + offset + 3).ToPointer();
                    r = *(byte*)(_bitmapData.Scan0 + offset + 2).ToPointer();
                    g = *(byte*)(_bitmapData.Scan0 + offset + 1).ToPointer();
                    b = *(byte*)(_bitmapData.Scan0 + offset + 0).ToPointer();
                }
                return Color.FromArgb(a, r, g, b);
            }

            return Color.White;
        }
        set
        {
            var offset = (int)(Math.Floor(y) * _width * 4 + Math.Floor(x) * 4);
            if (offset + 3 < Math.Abs(_bitmapData.Stride) * _bitmapData.Height)
            {
                unsafe
                {
                    *(byte*)(_bitmapData.Scan0 + offset + 3).ToPointer() = value.A;
                    *(byte*)(_bitmapData.Scan0 + offset + 2).ToPointer() = value.R;
                    *(byte*)(_bitmapData.Scan0 + offset + 1).ToPointer() = value.G;
                    *(byte*)(_bitmapData.Scan0 + offset + 0).ToPointer() = value.B;   
                }
            }
        }
    }

    public Bitmap GetResultBitmap()
    {
        _bitmap.UnlockBits(_bitmapData);

        return _bitmap;
    }

    public void Dispose()
    {
        _bitmap.Dispose();
    }
}

public enum CoordinatesType
{
    Real,
    Normalized
}