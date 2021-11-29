using DomainLayer;

namespace PresentationLayer.ViewLoaders
{
    public interface IViewLoader
    {
        void LoadMainView();
        void LoadHistogramView(HistogramParameters histogramParameters);
    }
}
