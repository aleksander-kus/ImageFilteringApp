using PresentationLayer.Presenters;
using System.Collections.Generic;

namespace PresentationLayer.Views
{
    public interface IHistogramView
    {
        Dictionary<int, int> RHistogram { set; }
        Dictionary<int, int> GHistogram { set; }
        Dictionary<int, int> BHistogram { set; }
        HistogramPresenter Presenter { set; }
        void RedrawHistograms();
    }
}
