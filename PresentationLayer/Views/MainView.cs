using PresentationLayer.Presenters;
using PresentationLayer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.Views
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;
        private int[] rHistogram;
        private int[] gHistogram;
        private int[] bHistogram;
        private readonly Image defaultImage;
        public MainView()
        {
            InitializeComponent();
            // Default image source: https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Earth_Western_Hemisphere_transparent_background.png/1200px-Earth_Western_Hemisphere_transparent_background.png
            defaultImage = Resources.earth;
            rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
        }

        public int CanvasWidth => pictureBox1.Width;
        public int CanvasHeight => pictureBox1.Height;

        public MainPresenter Presenter { set => presenter = value; }
        public Image CanvasImage { set => pictureBox1.Image = value; }

        public Image DefaultImage => defaultImage;

        public int[] RHistogram { set => rHistogram = value; }
        public int[] GHistogram { set => gHistogram = value; }
        public int[] BHistogram { set => bHistogram = value; }

        public void RedrawCanvas() => pictureBox1.Invalidate();
        public void RedrawHistograms()
        {
            DrawHistogram(rChart, rHistogram);
            DrawHistogram(gChart, gHistogram);
            DrawHistogram(bChart, bHistogram);
        }

        private void DrawHistogram(Chart chart, int[] histogram)
        {
            chart.Series[0].Points.Clear();
            for (int i = 0; i < histogram.Length; ++i)
                chart.Series[0].Points.AddXY(i + 1, histogram[i]);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
