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
        private CustomFilter filter;
        public ChartPointMode ChartPointMode { get; set; } = ChartPointMode.Adding;
        public CustomFunctionPresenter(ICustomFunctionView view, FilterParameters filterParameters)
        {
            this.view = view;
            this.filterParameters = filterParameters;
            if(this.filterParameters.Filter is CustomFilter)
                controlPoints = this.filterParameters.Filter.ControlPoints;
            else
            {
                controlPoints.Add(new Point(0, 0));
                controlPoints.Add(new Point(255, 255));
            }
            UpdateFunction();
        }
        public CurveMode CurveMode
        {
            set
            {
                if(filterParameters.CurveMode != value)
                {
                    filterParameters.CurveMode = value;
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

        public void Apply() => filterParameters.Filter = new CustomFilter(controlPoints);

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
            filter = new CustomFilter(controlPoints);
            view.Function = filterParameters.CurveMode == CurveMode.Normal ? filter.Function : filter.BezierFunction;
            view.HighlightedPoints = controlPoints;
            view.DrawFunction();
        }
    }
}
