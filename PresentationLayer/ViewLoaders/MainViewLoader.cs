using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;

namespace PresentationLayer.ViewLoaders
{
    class MainViewLoader : IViewLoader
    {
        private Form loadedView;
        public Form LoadedView => loadedView;

        public void LoadMainView()
        {
            MainView view = new();
            MainPresenter presenter = new(view, this);

            view.Presenter = presenter;

            LoadView(view);
        }

        private void LoadView(MainView view)
        {
            view.Show();
            loadedView = view;
        }
    }
}
