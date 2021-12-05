using System.Drawing;

namespace DomainLayer.Filters
{
    public class ContrastFilter : Filter
    {
        public ContrastFilter(int beginPoint)
        {
            if (beginPoint < 0 || beginPoint > 122)
                return;
            ControlPoints = new System.Collections.Generic.List<Point> { new Point(0, 0), new Point(beginPoint, 0), new Point(255 - beginPoint, 255), new Point(255, 255) };
        }
    }
}
