using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Filters
{
    public class NegationFilter : Filter
    {
        public NegationFilter()
        {
            ControlPoints = new List<Point> { new Point(0, 255), new Point(255, 0) };
        }
    }
}
