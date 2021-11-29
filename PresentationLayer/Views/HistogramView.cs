using PresentationLayer.Presenters;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.Views
{
    public partial class HistogramView : UserControl, IHistogramView
    {
        private HistogramPresenter presenter;
        private (int X, int Y)[] rHistogram = { (1, 1), (2, 2), (3, 3), (4, 4), (6, 5) };
        private Dictionary<int, int> gHistogram;
        private Dictionary<int, int> bHistogram;
        public HistogramView()
        {
            InitializeComponent();
            rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
            foreach(var (X, Y) in rHistogram)
                rChart.Series[0].Points.AddXY(X, Y);
        }

        public HistogramPresenter Presenter { set => presenter = value; }
        public Dictionary<int, int> RHistogram { set => rHistogram = null; }
        public Dictionary<int, int> GHistogram { set => gHistogram = value; }
        public Dictionary<int, int> BHistogram { set => bHistogram = value; }

        public void RedrawHistograms()
        {
            rChart.Series[0].Points.Clear();
        }
    }
}
