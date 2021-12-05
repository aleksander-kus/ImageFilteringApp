using DomainLayer;
using DomainLayer.Dto;
using DomainLayer.Filters;
using PresentationLayer.Presenters;
using PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.Views
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;
        private ColorHistograms colorHistograms;
        private int[] function;
        private Image canvasImage;
        private bool mouseDown = false;

        private CurveMode curveMode = CurveMode.Normal;
        public CurveMode CurveMode
        {
            set
            {
                if(curveMode != value)
                {
                    curveMode = value;
                    if (curveMode == CurveMode.Normal)
                        normalCurveButton.Checked = true;
                    else
                        bezierCurveButton.Checked = true;
                }
            }
        }
        public MainView()
        {
            InitializeComponent();
            // Earth image source: https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Earth_Western_Hemisphere_transparent_background.png/1200px-Earth_Western_Hemisphere_transparent_background.png
            rChart.Legends.Clear();
            gChart.Legends.Clear();
            bChart.Legends.Clear();
            functionChart.Legends.Clear();
            functionChart.ChartAreas[0].AxisY.Maximum = 255;
            functionChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            functionChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public ColorHistograms ColorHistograms { set => colorHistograms = value; }
        public int CanvasWidth => bufferedPanel1.Width;
        public int CanvasHeight => bufferedPanel1.Height;
        public MainPresenter Presenter { set => presenter = value; }
        public Image CanvasImage { set => canvasImage = value; }
        public int[] Function { set => function = value; }

        public Image DefaultImage => Resources.earth;

        public void RedrawCanvas() => bufferedPanel1.Invalidate();
        public void RedrawHistograms()
        {
            DrawHistogram(rChart, colorHistograms.RHistogram);
            DrawHistogram(gChart, colorHistograms.GHistogram);
            DrawHistogram(bChart, colorHistograms.BHistogram);
            DrawFunction();
        }

        private void DrawHistogram(Chart chart, int[] histogram)
        {
            if (histogram == null)
                return;
            chart.Series[0].Points.Clear();
            for (int i = 1; i < histogram.Length - 1; ++i)
                chart.Series[0].Points.AddXY(i, histogram[i]);
        }

        private List<Point> highlightedPoints = new List<Point>();
        public List<Point> HighlightedPoints { set => highlightedPoints = value; }

        public void DrawFunction()
        {
            if (function == null)
                return;
            functionChart.Series[0].Points.Clear();
            for (int i = 0; i < function.Length - 1; ++i)
                functionChart.Series[0].Points.AddXY(i, function[i]);
            if (functionChart.Series.Count > 1)
                functionChart.Series.RemoveAt(1);
            var highlighted = new Series("Highlighted")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.Black,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };
            foreach (var point in highlightedPoints)
                highlighted.Points.AddXY(point.X, point.Y);
            functionChart.Series.Add(highlighted);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void noFilterButton_Click(object sender, EventArgs e) => presenter.Filter = new NoFilter();

        private void negationButton_Click(object sender, EventArgs e) => presenter.Filter = new NegationFilter();

        private void brightnessButton_Click(object sender, EventArgs e) => brightnessBox_ValueChanged(null, null);
        private void brightnessBox_ValueChanged(object sender, EventArgs e)
        {
            if (brightnessButton.Checked)
                presenter.Filter = new BrightnessFilter((int)brightnessBox.Value);
        }

        private void gammaButton_Click(object sender, EventArgs e) => gammaBox_ValueChanged(null, null);
        private void gammaBox_ValueChanged(object sender, EventArgs e)
        {
            if (gammaButton.Checked)
                presenter.Filter = new GammaFilter((double)gammaBox.Value);
        }

        private void contrastButton_Click(object sender, EventArgs e) => contrastBox_ValueChanged(null, null);
        private void contrastBox_ValueChanged(object sender, EventArgs e)
        {
            if(contrastButton.Checked)
                presenter.Filter = new ContrastFilter((int)contrastBox.Value);
        }
        private void wholeButton_Click(object sender, EventArgs e) => presenter.SelectionMode = DomainLayer.SelectionMode.Whole;

        private void brushButton_Click(object sender, EventArgs e) => presenter.SelectionMode = DomainLayer.SelectionMode.Brush;

        private void polygonButton_Click(object sender, EventArgs e) => presenter.SelectionMode = DomainLayer.SelectionMode.Polygon;

        private void bufferedPanel1_Paint(object sender, PaintEventArgs e) => e.Graphics.DrawImage(canvasImage, new Point(0, 0));

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

        private void bufferedPanel1_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;

        private void addPolygonButton_Click(object sender, EventArgs e) => presenter.PolygonMode = DomainLayer.PolygonMode.Adding;

        private void removePolygonButton_Click(object sender, EventArgs e) => presenter.PolygonMode = DomainLayer.PolygonMode.Removing;

        private void customFunctionButton_Click(object sender, EventArgs e)
        {
            customButton.Checked = true;
            presenter.DefineCustomFunction();
        }

        private void tajMahalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            earthToolStripMenuItem1.Checked = false;
            tajMahalToolStripMenuItem1.Checked = true;
            presenter.LoadBitmapFromImage(Resources.Taj_Mahal_Agra_India);
            ResetPresenter();
        }

        private void earthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tajMahalToolStripMenuItem1.Checked = false;
            earthToolStripMenuItem1.Checked = true;
            presenter.LoadBitmapFromImage(Resources.earth);
            ResetPresenter();
        }

        private void ResetPresenter()
        {
            presenter.SelectionMode = DomainLayer.SelectionMode.Whole;
            presenter.Filter = new NoFilter();
            wholeButton.Checked = true;
            noFilterButton.Checked = true;
        }

        private void loadFromFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (od.ShowDialog() == DialogResult.OK)
            {
                presenter.LoadBitmapFromImage(Image.FromFile(od.FileName));
                ResetPresenter();
                earthToolStripMenuItem1.Checked = false;
                tajMahalToolStripMenuItem1.Checked = false;
            }    
        }

        private void normalCurveButton_Click(object sender, EventArgs e) => presenter.CurveMode = curveMode = CurveMode.Normal;

        private void bezierCurveButton_Click(object sender, EventArgs e) => presenter.CurveMode = curveMode = CurveMode.Bezier;
    }
}
