using DomainLayer;
using PresentationLayer.Views;

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
        }

        private void HistogramParameters_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) => 
            GetHistogramsFromBitmap();

        private void GetHistogramsFromBitmap()
        {

        }
    }
}
