using DomainLayer;
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;

namespace PresentationLayer.ViewLoaders
{
    class ControlViewLoader : IViewLoader
    {
        private Control loadedView;
        public Control LoadedView => loadedView;

        public void LoadHistogramView(HistogramParameters histogramParameters)
        {
            HistogramView view = new();
            HistogramPresenter presenter = new(view, histogramParameters);

            view.Presenter = presenter;

            LoadView(view);
        }

        public void LoadMainView()
        {
            MainView view = new();
            MainPresenter presenter = new(view, this);

            view.Presenter = presenter;

            LoadView(view);
        }

        private void LoadView(Control view)
        {
            view.Show();
            loadedView = view;
        }
    }
}
