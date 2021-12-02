using System.Drawing;

namespace InfrastructureLayer
{
    public interface IDrawingService
    {
        Bitmap OriginalBitmap { set; }
        Bitmap DrawBitmap();
    }
}