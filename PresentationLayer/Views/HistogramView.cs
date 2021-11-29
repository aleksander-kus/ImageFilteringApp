using PresentationLayer.Presenters;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class HistogramView : UserControl, IHistogramView
    {
        private HistogramPresenter presenter;
        public HistogramView()
        {
            InitializeComponent();
        }

        public HistogramPresenter Presenter { set => presenter = value; }
    }
}
