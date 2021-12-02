using DomainLayer.Dto;
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System.Windows.Forms;

namespace PresentationLayer.ViewLoaders
{
    class ViewLoader : IViewLoader
    {
        private Form lastLoadedForm;
        public Form LastLoadedForm => lastLoadedForm;

        public void LoadCustomFunctionView(FilterParameters filterParameters)
        {
            CustomFunctionView view = new CustomFunctionView();
            CustomFunctionPresenter presenter = new CustomFunctionPresenter(view, filterParameters);

            view.Presenter = presenter;

            LoadView(view);
        }

        public void LoadMainView()
        {
            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(view, this);

            view.Presenter = presenter;

            LoadView(view);
        }

        private void LoadView(Form view)
        {
            view.Show();
            lastLoadedForm = view;
        }
    }
}
