using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DomainLayer.Filters
{
    public abstract class Filter
    {
        private List<Point> controlPoints = new List<Point>();
        public List<Point> ControlPoints {
            get => controlPoints;
            protected set
            {
                controlPoints = value;
                if (controlPoints.Count < 2)
                    return;
                GetFuncionFromPoints();
                GetFunctionFromPointsBezier();
            }
        }

        public int[] BezierFunction { get; private set; } = new int[256];

        public int[] Function { get; private set; } = new int[256];

        public Color Transform(Color color) => 
            Color.FromArgb(Function[color.R], Function[color.G], Function[color.B]);

        public Color BezierTransform(Color color) =>
            Color.FromArgb(BezierFunction[color.R], BezierFunction[color.G], BezierFunction[color.B]);

        private void GetFuncionFromPoints()
        {
            var sortedControlPoints = new List<Point>(controlPoints);
            sortedControlPoints.Sort((p1, p2) => p1.X.CompareTo(p2.X));
            for (int i = 0; i < sortedControlPoints.Count - 1; ++i)
                ConnectTwoPoints(sortedControlPoints[i], sortedControlPoints[i + 1]);
        }

        private void ConnectTwoPoints(PointF p1, PointF p2)
        {
            if (p1.Equals(p2))
                return;
            float a = (p2.Y - p1.Y) / (p2.X - p1.X);
            float b = p2.Y - a * p2.X;
            int f(int x) => (int)(a * x + b);
            for (int i = (int)p1.X; i <= p2.X; ++i)
                Function[i] = f(i);
        }

        private void GetFunctionFromPointsBezier()
        {
            var bezierCurve = new List<PointF>();
            for (float t = 0; t < 1; t += 1 / 256f)
            {
                var list1 = new List<PointF>(controlPoints.Select(p => new PointF(p.X, p.Y)));
                while (list1.Count > 1)
                {
                    var list2 = new List<PointF>();
                    for (int i = 0; i < list1.Count - 1; ++i)
                    {
                        PointF p1 = list1[i];
                        PointF p2 = list1[i + 1];
                        float x = p1.X * (1 - t) + p2.X * t;
                        float y = p1.Y * (1 - t) + p2.Y * t;

                        list2.Add(new PointF(x, y));
                    }

                    list1 = list2;
                }
                bezierCurve.Add(list1[0]);
            }
            for (int i = 0; i < bezierCurve.Count && i < BezierFunction.Length; ++i)
                BezierFunction[i] = (int)bezierCurve[i].Y;
        }
    }
}
