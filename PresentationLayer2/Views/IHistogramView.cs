using PresentationLayer.Presenters;

namespace PresentationLayer.Views
{
    public interface IHistogramView
    {
        HistogramPresenter Presenter { set; }
    }
}
