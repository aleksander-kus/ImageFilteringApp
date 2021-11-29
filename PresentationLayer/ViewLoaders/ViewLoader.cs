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

        public void LoadMainView()
        {
            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(view, this);

            view.Presenter = presenter;

            LoadForm(view);
        }

        private void LoadForm(Form view)
        {
            view.Show();
            lastLoadedForm = view;
        }
    }
}
