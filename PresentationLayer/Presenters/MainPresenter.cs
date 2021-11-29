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
        private FilterMode filterMode = FilterMode.NoFilter;
        public FilterMode FilterMode
        {
            set
            {
                if(filterMode != value)
                {
                    filterMode = value;
                    switch (filterMode)
                    {
                        case FilterMode.NoFilter:
                            filter = new NoFilter();
                            break;
                        case FilterMode.Negation:
                            filter = new NegationFilter();
                            break;
                    }
                    GetHistogramsFromBitmap();
                }
            }
        }
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            bitmap = new Bitmap(view.DefaultImage);
            this.view.CanvasImage = bitmap;
            filter = new NoFilter();
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
                    if (color.A != 255)
                        continue;
                    Color newColor = filter.Transform(color);
                    ++rHistogram[newColor.R];
                    ++gHistogram[newColor.G];
                    ++bHistogram[newColor.B];

                    byteBitmap.SetPixel(i, j, newColor);
                }
            }
            view.RHistogram = rHistogram;
            view.GHistogram = gHistogram;
            view.BHistogram = bHistogram;
            view.Function = filter.Function;
            view.CanvasImage = byteBitmap.Bitmap;
            view.RedrawCanvas();
            view.RedrawHistograms();
        }
    }
}
