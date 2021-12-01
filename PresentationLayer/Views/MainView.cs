using DomainLayer.Filters;
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
        private Image canvasImage;
        private bool mouseDown = false;
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
        public Image CanvasImage { set => canvasImage = value; }

        public Image DefaultImage => defaultImage;

        public int[] RHistogram { set => rHistogram = value; }
        public int[] GHistogram { set => gHistogram = value; }
        public int[] BHistogram { set => bHistogram = value; }
        public int[] Function { set => function = value; }

        public void RedrawCanvas() => bufferedPanel1.Invalidate();
        public void RedrawHistograms()
        {
            DrawHistogram(rChart, rHistogram);
            DrawHistogram(gChart, gHistogram);
            DrawHistogram(bChart, bHistogram);
            DrawHistogram(functionChart, function);
        }

        private void DrawHistogram(Chart chart, int[] histogram)
        {
            if (histogram == null)
                return;
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
            presenter.Filter = new NoFilter();
        }

        private void negationButton_Click(object sender, EventArgs e)
        {
            presenter.Filter = new NegationFilter();
        }


        private void brushButton_Click(object sender, EventArgs e)
        {
            presenter.SelectionMode = DomainLayer.SelectionMode.Brush;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            presenter.SelectionMode = DomainLayer.SelectionMode.Polygon;
        }

        private void wholeButton_Click(object sender, EventArgs e)
        {
            presenter.SelectionMode = DomainLayer.SelectionMode.Whole;
        }

        private void bufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvasImage, new Point(0, 0));
        }

        private void bufferedPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            presenter.RegisterCanvasClick(e.Location);
        }

        private void bufferedPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                presenter.RegisterCanvasMouseMove(e.Location);
        }

        private void bufferedPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void brightnessButton_Click(object sender, EventArgs e)
        {
            brightnessBox_ValueChanged(null, null);
        }

        private void brightnessBox_ValueChanged(object sender, EventArgs e)
        {
            if (brightnessButton.Checked)
                presenter.Filter = new BrightnessFilter((int)brightnessBox.Value);
        }

        private void gammaButton_Click(object sender, EventArgs e)
        {
            gammaBox_ValueChanged(null, null);
        }

        private void gammaBox_ValueChanged(object sender, EventArgs e)
        {
            if (gammaButton.Checked)
                presenter.Filter = new GammaFilter((double)gammaBox.Value);
        }

        private void contrastButton_Click(object sender, EventArgs e)
        {
            contrastBox_ValueChanged(null, null);
        }

        private void contrastBox_ValueChanged(object sender, EventArgs e)
        {
            if(contrastButton.Checked)
                presenter.Filter = new ContrastFilter((int)contrastBox.Value);
        }

        private void addPolygonButton_Click(object sender, EventArgs e)
        {
            presenter.AddingPolygon = true;
        }

        private void removePolygonButton_Click(object sender, EventArgs e)
        {
            presenter.RemovingPolygon = true;
        }
    }
}
