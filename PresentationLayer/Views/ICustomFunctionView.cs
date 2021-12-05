using DomainLayer;
using PresentationLayer.Presenters;
using System.Collections.Generic;
using System.Drawing;

namespace PresentationLayer.Views
{
    public interface ICustomFunctionView
    {
        CustomFunctionPresenter Presenter { set; }

        int[] Function { set; }
        List<Point> HighlightedPoints { set; }
        CurveMode CurveMode { set; }

        void DrawFunction();
    }
}
