using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Filters
{
    public class NoFilter : Filter
    {
        public NoFilter()
        {
            ControlPoints = new List<Point> { new Point(0, 0), new Point(255, 255) };
        }
    }
}
