using PresentationLayer.Presenters;
using System.Collections.Generic;

namespace PresentationLayer.Views
{
    public interface IHistogramView
    {
        int[] RHistogram { set; }
        int[] GHistogram { set; }
        int[] BHistogram { set; }
        HistogramPresenter Presenter { set; }
        void RedrawHistograms();
    }
}
