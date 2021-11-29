using DomainLayer;
using PresentationLayer.Views;
using System.Drawing;

namespace PresentationLayer.Presenters
{
    public class HistogramPresenter
    {
        private readonly IHistogramView view;
        private readonly HistogramParameters histogramParameters;
        public HistogramPresenter(IHistogramView view, HistogramParameters histogramParameters)
        {
            this.view = view;
            this.histogramParameters = histogramParameters;
            this.histogramParameters.PropertyChanged += HistogramParameters_PropertyChanged;
            GetHistogramsFromBitmap();
        }

        private void HistogramParameters_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) => 
            GetHistogramsFromBitmap();

        private void GetHistogramsFromBitmap()
        {
            ByteBitmap bitmap = new ByteBitmap(histogramParameters.Bitmap);
            int[] rHistogram = new int[256];
            int[] gHistogram = new int[256];
            int[] bHistogram = new int[256];
            for(int i = 0; i < bitmap.Width; ++i)
            {
                for(int j = 0; j < bitmap.Height; ++j)
                {
                    Color c = bitmap.GetPixel(i, j);
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
