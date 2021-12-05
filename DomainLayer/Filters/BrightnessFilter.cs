using System.Drawing;

namespace DomainLayer.Filters
{
    public class BrightnessFilter : Filter
    {
        public BrightnessFilter(int beginPoint)
        {
            ControlPoints = beginPoint < 0
                ? new System.Collections.Generic.List<Point> { new Point(0, 0), new Point(-beginPoint, 0), new Point(255, 255 - (-beginPoint)) }
                : new System.Collections.Generic.List<Point> { new Point(0, beginPoint), new Point(255 - beginPoint, 255), new Point(255, 255) };
        }
    }
}
