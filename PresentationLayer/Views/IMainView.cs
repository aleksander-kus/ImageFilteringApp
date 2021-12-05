using DomainLayer;
using DomainLayer.Dto;
using PresentationLayer.Presenters;
using System.Collections.Generic;
using System.Drawing;

namespace PresentationLayer.Views
{
    public interface IMainView
    {
        ColorHistograms ColorHistograms { set; }
        int[] Function { set; }
        MainPresenter Presenter { set; }
        int CanvasWidth { get; }
        int CanvasHeight { get; }
        Image CanvasImage { set; }
        Image DefaultImage { get; }
        List<Point> HighlightedPoints { set; }
        CurveMode CurveMode { set; }
        void RedrawCanvas();
        void RedrawHistograms();
        void DrawFunction();
    }
}
