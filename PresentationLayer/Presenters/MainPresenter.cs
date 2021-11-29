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

            bitmap = new Bitmap(view.DefaultImage);
            this.view.CanvasImage = bitmap;
            histogramParameters = new HistogramParameters()
            {
                Bitmap = bitmap
            };
            viewLoader.LoadHistogramView(histogramParameters);
        }
    }
}
