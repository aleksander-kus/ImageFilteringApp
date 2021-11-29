using DomainLayer;
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
        private readonly HistogramParameters histogramParameters;
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;

            bitmap = new(this.view.CanvasWidth, this.view.CanvasHeight);
            this.view.CanvasImage = bitmap;
            histogramParameters = new()
            {
                Bitmap = bitmap
            };
            viewLoader.LoadHistogramView(histogramParameters);
        }
    }
}
