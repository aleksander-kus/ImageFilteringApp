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
        private int[] function;
        private readonly Image defaultImage;
        public MainView()
        {
            InitializeComponent();
            // Default image source: https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Earth_Western_Hemisphere_transparent_background.png/1200px-Earth_Western_Hemisphere_transparent_background.png
            defaultImage = Resources.earth;
            rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
            functionChart.Legends.Clear();
            functionChart.ChartAreas[0].AxisY.Maximum = 255;
            functionChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            functionChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public int CanvasWidth => pictureBox1.Width;
        public int CanvasHeight => pictureBox1.Height;

        public MainPresenter Presenter { set => presenter = value; }
        public Image CanvasImage { set => pictureBox1.Image = value; }

        public Image DefaultImage => defaultImage;

        public int[] RHistogram { set => rHistogram = value; }
        public int[] GHistogram { set => gHistogram = value; }
        public int[] BHistogram { set => bHistogram = value; }
        public int[] Function { set => function = value; }

        public void RedrawCanvas() => pictureBox1.Invalidate();
        public void RedrawHistograms()
        {
            DrawHistogram(rChart, rHistogram);
            DrawHistogram(gChart, gHistogram);
            DrawHistogram(bChart, bHistogram);
            DrawHistogram(functionChart, function);
        }

        private void DrawHistogram(Chart chart, int[] histogram)
        {
            chart.Series[0].Points.Clear();
            for (int i = 1; i < histogram.Length - 1; ++i)
                chart.Series[0].Points.AddXY(i, histogram[i]);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void noFilterButton_Click(object sender, EventArgs e)
        {
            presenter.FilterMode = DomainLayer.Filters.FilterMode.NoFilter;
        }

        private void negationButton_Click(object sender, EventArgs e)
        {
            presenter.FilterMode = DomainLayer.Filters.FilterMode.Negation;
        }

        private void brightnessButton_Click(object sender, EventArgs e)
        {
            presenter.FilterMode = DomainLayer.Filters.FilterMode.Brightness;
        }
    }
}
