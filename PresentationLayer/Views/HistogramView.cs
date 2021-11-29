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
            rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
        }

        public HistogramPresenter Presenter { set => presenter = value; }
    }
}
