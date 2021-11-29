using PresentationLayer.Presenters;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.Views
{
    public partial class HistogramView : UserControl, IHistogramView
    {
        private HistogramPresenter presenter;
        private int[] rHistogram;
        private int[] gHistogram;
        private int[] bHistogram;
        public HistogramView()
        {
            InitializeComponent();
            //rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
            //rChart.ChartAreas[0].AxisY.Minimum = 0;
            //rChart.ChartAreas[0].AxisY.Maximum = 10000;
            for (int i = 1; i < 5; ++i)
                rChart.Series[0].Points.AddXY(i, i);
        }

        public HistogramPresenter Presenter { set => presenter = value; }
        public int[] RHistogram { set => rHistogram = value; }
        public int[] GHistogram { set => gHistogram = value; }
        public int[] BHistogram { set => bHistogram = value; }

        public void RedrawHistograms()
        {
            //rChart.Series.Clear();
            //Series s = new Series("MYSERIES");
            ////for (int i = 1; i < rHistogram.Length; ++i)
            ////    rChart.Series[0].Points.AddXY(i, rHistogram[i]);
            //MessageBox.Show(">>>>>>>>>>>>>>>>>");
            //for (int i = 1; i < 6; ++i)
            //    s.Points.AddXY(i, i);
            //rChart.Series.Add(s);
            //rChart.Refresh(); rChart.Update(); rChart.Invalidate();
            //this.Invalidate();
            bChart.Series[0].Points.AddXY(0, 10);
            MessageBox.Show($"{bChart.Series[0].Points.Count}");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            RedrawHistograms();

        }
    }
}
