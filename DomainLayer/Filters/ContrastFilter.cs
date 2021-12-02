using System.Drawing;

namespace DomainLayer.Filters
{
    public class ContrastFilter : Filter
    {
        public ContrastFilter(int beginPoint)
        {
            if (beginPoint < 0 || beginPoint > 122)
                return;
            for (int i = 0; i < beginPoint; ++i)
                function[i] = 0;
            for (int i = 255 - beginPoint; i < function.Length; ++i)
                function[i] = 255;
            ConnectTwoPoints(new PointF(beginPoint, 0), new PointF(255 - beginPoint, 255));
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
