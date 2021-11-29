using DomainLayer;
using PresentationLayer.ViewLoaders;
using PresentationLayer.Views;
using System.Drawing;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        private Bitmap bitmap;
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            bitmap = new Bitmap(view.DefaultImage);
            this.view.CanvasImage = bitmap;
            GetHistogramsFromBitmap();
        }

        private void GetHistogramsFromBitmap()
        {
            ByteBitmap byteBitmap = new ByteBitmap(bitmap);
            int[] rHistogram = new int[256];
            int[] gHistogram = new int[256];
            int[] bHistogram = new int[256];
            for (int i = 0; i < byteBitmap.Width; ++i)
            {
                for (int j = 0; j < byteBitmap.Height; ++j)
                {
                    Color c = byteBitmap.GetPixel(i, j);
                    if (c.A == 0)
                        continue;
                    ++rHistogram[c.R];
                    ++gHistogram[c.G];
                    ++bHistogram[c.B];
                }
            }
            view.RHistogram = rHistogram;
            view.GHistogram = gHistogram;
            view.BHistogram = bHistogram;
            view.RedrawHistograms();
        }
    }
}
