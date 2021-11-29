using DomainLayer;
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;

namespace PresentationLayer.ViewLoaders
{
    class ViewLoader : IViewLoader
    {
        private Form lastLoadedForm;
        public Form LastLoadedForm => lastLoadedForm;
        
        private Control lastLoadedControl;
        public Control LastLoadedControl => lastLoadedControl;

        public void LoadHistogramView(HistogramParameters histogramParameters)
        {
            HistogramView view = new();
            HistogramPresenter presenter = new(view, histogramParameters);

            view.Presenter = presenter;

            LoadControl(view);
        }

        public void LoadMainView()
        {
            MainView view = new();
            MainPresenter presenter = new(view, this);

            view.Presenter = presenter;

            LoadForm(view);
        }

        private void LoadForm(Form view)
        {
            view.Show();
            lastLoadedForm = view;
        }

        private void LoadControl(Control view)
        {
            lastLoadedControl = view;
        }
    }
}
