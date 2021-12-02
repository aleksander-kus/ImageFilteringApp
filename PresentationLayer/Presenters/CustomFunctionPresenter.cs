using DomainLayer;
using DomainLayer.Dto;
using DomainLayer.Filters;
using PresentationLayer.Views;
using System.Collections.Generic;
using System.Drawing;

namespace PresentationLayer.Presenters
{
    public class CustomFunctionPresenter
    {
        private readonly ICustomFunctionView view;
        private readonly FilterParameters filterParameters;
        private readonly List<Point> controlPoints = new List<Point>();
        private readonly int[] function = new int[256];
        private int movingPointId = -1;
        public ChartPointMode ChartPointMode { get; set; } = ChartPointMode.Adding;
        public CustomFunctionPresenter(ICustomFunctionView view, FilterParameters filterParameters)
        {
            this.view = view;
            this.filterParameters = filterParameters;
            controlPoints.Add(new Point(0, 0));
            controlPoints.Add(new Point(255, 255));
            //controlPoints.Add(new Point(100, 200));
            UpdateFunction();
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

        public void Apply()
        {
            filterParameters.Filter = new CustomFilter(function);
        }

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
            ConnectControlPoints();
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
    }
}
