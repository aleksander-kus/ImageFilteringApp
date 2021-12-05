using DomainLayer;
using DomainLayer.Dto;
using DomainLayer.Filters;
using PresentationLayer.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PresentationLayer.Presenters
{
    public class CustomFunctionPresenter
    {
        private readonly ICustomFunctionView view;
        private readonly FilterParameters filterParameters;
        private readonly List<Point> controlPoints = new List<Point>();
        private readonly int[] function = new int[256];
        public ChartPointMode ChartPointMode { get; set; } = ChartPointMode.Adding;
        public CustomFunctionPresenter(ICustomFunctionView view, FilterParameters filterParameters)
        {
            this.view = view;
            this.filterParameters = filterParameters;
            controlPoints.Add(new Point(0, 0));
            controlPoints.Add(new Point(255, 255));
            UpdateFunction();
        }
        private CurveMode curveMode;
        public CurveMode CurveMode
        {
            set
            {
                if(curveMode != value)
                {
                    curveMode = value;
                    UpdateFunction();
                }
            }
        }

        public void RegisterChartClick(Point mousePosition)
        {
            if (mousePosition.X >= 255 || mousePosition.X < 0 || mousePosition.Y >= 255 || mousePosition.Y < 0)
                return;
            if (ChartPointMode == ChartPointMode.Adding)
                controlPoints.Add(mousePosition);
            else
                RemoveControlPoint(mousePosition);
            UpdateFunction();
        }

        public void Apply() => filterParameters.Filter = new CustomFilter(function);

        private void RemoveControlPoint(Point mousePosition)
        {
            var index = controlPoints.FindIndex(p => IsPointClicked(p, mousePosition));
            if (index <= 0 || index == controlPoints.Count - 1)
                return;
            controlPoints.RemoveAt(index);
        }

        private static int SquaredDistance(Point p1, Point p2) => (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
        private static bool IsPointClicked(Point point, Point mousePosition, int epsilon = 10) => SquaredDistance(point, mousePosition) <= epsilon * epsilon;

        private void UpdateFunction()
        {
            controlPoints.Sort((p1, p2) => p1.X.CompareTo(p2.X));
            if (curveMode == CurveMode.Normal)
                ConnectControlPoints();
            else
                ComputeBezier();
            view.Function = function;
            view.HighlightedPoints = controlPoints;
            view.DrawFunction();
        }

        private void ConnectControlPoints()
        {
            for (int i = 0; i < controlPoints.Count - 1; ++i)
                ConnectTwoPoints(controlPoints[i], controlPoints[i + 1]);
        }

        private void ConnectTwoPoints(PointF p1, PointF p2)
        {
            float a = (p2.Y - p1.Y) / (p2.X - p1.X);
            float b = p2.Y - a * p2.X;
            int f(int x) => (int)(a * x + b);
            for (int i = (int)p1.X; i <= p2.X; ++i)
                function[i] = f(i);
        }

        private PointF approx(float t, PointF p1, PointF p2)
        {
            float x = p1.X * (1 - t) + p2.X * t;
            float y = p1.Y * (1 - t) + p2.Y * t;
            return new PointF(x, y);
        }

        private void ComputeBezier()
        {
            List<PointF> bezierCurve = new List<PointF>();
            for(float t = 0; t < 1; t += 1/256f)
            {
                List<PointF> temp1 = new List<PointF>(controlPoints.Select(p => new PointF(p.X, p.Y)));
                while(temp1.Count > 1)
                {
                    List<PointF> temp2 = new List<PointF>();
                    for(int i = 0; i < temp1.Count - 1; ++i)
                    {
                        PointF p1 = temp1[i];
                        PointF p2 = temp1[i + 1];

                        temp2.Add(approx(t, p1, p2));
                    }

                    temp1 = temp2;
                }
                bezierCurve.Add(temp1[0]);
            }
            for (int i = 0; i < bezierCurve.Count && i < function.Length; ++i)
                function[i] = (int)bezierCurve[i].Y;
        }
    }
}
