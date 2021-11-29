using PresentationLayer.Presenters;
using System.Drawing;

namespace PresentationLayer.Views
{
    public interface IMainView
    {
        int[] RHistogram { set; }
        int[] GHistogram { set; }
        int[] BHistogram { set; }
        MainPresenter Presenter { set; }
        int CanvasWidth { get; }
        int CanvasHeight { get; }
        Image CanvasImage { set; }
        Image DefaultImage { get; }
        void RedrawCanvas();
        void RedrawHistograms();
    }
}
