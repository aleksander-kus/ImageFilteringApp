using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Filters
{
    public class CustomFilter : Filter
    {
        public CustomFilter(List<Point> controlPoints)
        {
            controlPoints.Remove(new Point(255, 255));
            controlPoints.Add(new Point(255, 255));
            ControlPoints = controlPoints;
        }
    }
}
