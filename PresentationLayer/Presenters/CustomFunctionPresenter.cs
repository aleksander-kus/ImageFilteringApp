using DomainLayer.Dto;
using PresentationLayer.Views;
using System.Collections.Generic;
using System.Drawing;

namespace PresentationLayer.Presenters
{
    public class CustomFunctionPresenter
    {
        private readonly ICustomFunctionView view;
        private readonly FilterParameters filterParameters;
        private List<Point> controlPoints = new List<Point>();
        private int[] function = new int[256];
        public CustomFunctionPresenter(ICustomFunctionView view, FilterParameters filterParameters)
        {
            this.view = view;
            this.filterParameters = filterParameters;
            controlPoints.Add(new Point(0, 0));
            controlPoints.Add(new Point(255, 255));
            controlPoints.Add(new Point(100, 200));
            ConnectControlPoints();
            this.view.Function = function;
            this.view.HighlightedPoints = controlPoints;
            this.view.DrawFunction();
            this.view.DrawFunction();
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
            for (int i = (int)p1.X; i < p2.X; ++i)
                function[i] = f(i);
        }
    }
}
