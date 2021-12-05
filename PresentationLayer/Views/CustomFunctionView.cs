using DomainLayer;
using PresentationLayer.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.Views
{
    public partial class CustomFunctionView : Form, ICustomFunctionView
    {
        private CustomFunctionPresenter presenter;
        private int[] function;
        private List<Point> highlightedPoints;
        public CustomFunctionView()
        {
            InitializeComponent();
            functionChart.Legends.Clear();
            functionChart.ChartAreas[0].AxisX.Minimum = 0;
            functionChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            functionChart.ChartAreas[0].AxisY.Maximum = 255;
            functionChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public CustomFunctionPresenter Presenter { set => presenter = value; }
        public int[] Function { set => function = value; }
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
                MarkerSize = 7
            };
            foreach (var point in highlightedPoints)
                highlighted.Points.AddXY(point.X, point.Y);
            functionChart.Series.Add(highlighted);
        }

        private void CustomFunctionView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) => Close();

        private void applyButton_Click(object sender, EventArgs e) => presenter.Apply();

        private void okButton_Click(object sender, EventArgs e)
        {
            presenter.Apply();
            Close();
        }

        private void functionChart_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round(functionChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            int y = (int)Math.Round(functionChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
            presenter.RegisterChartClick(new Point(x, y));
        }

        private void removePointsButton_Click(object sender, EventArgs e) => presenter.ChartPointMode = ChartPointMode.Removing;

        private void addPointsButton_Click(object sender, EventArgs e) => presenter.ChartPointMode = ChartPointMode.Adding;

        private void bezierCurveButton_Click(object sender, EventArgs e)
        {
            presenter.CurveMode = CurveMode.Bezier;
        }

        private void normalCurveButton_Click(object sender, EventArgs e)
        {
            presenter.CurveMode = CurveMode.Normal;
        }
    }
}
