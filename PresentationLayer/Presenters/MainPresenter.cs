using PresentationLayer.ViewLoaders;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly IViewLoader viewLoader;
        public MainPresenter(IMainView view, IViewLoader viewLoader)
        {
            this.view = view;
            this.viewLoader = viewLoader;
        }
    }
}
