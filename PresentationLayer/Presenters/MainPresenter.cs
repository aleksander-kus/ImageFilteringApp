using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView view;
        public MainPresenter(IMainView v)
        {
            view = v;
        }
    }
}
