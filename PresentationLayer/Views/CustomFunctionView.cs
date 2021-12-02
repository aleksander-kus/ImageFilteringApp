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
                Color = Color.Black
            };
            foreach (var point in highlightedPoints)
            {
                highlighted.Points.AddXY(point.X, point.Y);
                highlighted.Points.Last().MarkerStyle = MarkerStyle.Circle;
                highlighted.Points.Last().MarkerSize = 7;
            }
            functionChart.Series.Add(highlighted);
        }

        private void CustomFunctionView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
