using DomainLayer;
using DomainLayer.Filters;
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
        private Filter filter;
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            bitmap = new Bitmap(view.DefaultImage);
            this.view.CanvasImage = bitmap;
            filter = new NegationFilter();
            GetHistogramsFromBitmap();
        }

        private void GetHistogramsFromBitmap()
        {
            ByteBitmap byteBitmap = new ByteBitmap(bitmap);
            int[] rHistogram = new int[256];
            int[] gHistogram = new int[256];
            int[] bHistogram = new int[256];
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = byteBitmap.GetPixel(i, j);
                    Color newColor = filter.Transform(color);
                    if (color.A == 255)
                    {
                        ++rHistogram[newColor.R];
                        ++gHistogram[newColor.G];
                        ++bHistogram[newColor.B];
                    }

                    byteBitmap.SetPixel(i, j, newColor);
                }
            }
            view.RHistogram = rHistogram;
            view.GHistogram = gHistogram;
            view.BHistogram = bHistogram;
            bitmap = byteBitmap.Bitmap;
            view.CanvasImage = bitmap;
            view.RedrawHistograms();
        }
    }
}
