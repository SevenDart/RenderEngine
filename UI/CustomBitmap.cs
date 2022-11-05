using System.Drawing.Imaging;

namespace UI;

public class CustomBitmap : IDisposable
{
    private Bitmap _bitmap;
    private BitmapData _bitmapData;

    private int _width;
    private int _height;
    
    public CustomBitmap(int width, int height)
    {
        _width = width;
        _height = height;
        _bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        
        _bitmapData = _bitmap.LockBits(new Rectangle(0, 0, width, height), 
            ImageLockMode.ReadWrite, 
            _bitmap.PixelFormat);
    }

    public Color this[float x, float y]
    {
        get
        {
            var offset = (int)(y * _width * 4 + x * 4);
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