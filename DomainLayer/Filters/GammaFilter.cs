using System;
using System.Collections.Generic;
using System.Drawing;

namespace DomainLayer.Filters
{
    public class GammaFilter : Filter
    {
        public GammaFilter(double gamma)
        {
            ControlPoints = new List<Point> { new Point(0, 0), new Point(255, 255) };
            for (int i = 0; i < Function.Length; ++i)
                Function[i] = (int)Math.Round(Math.Pow(i / 255.0, 1.0/gamma) * 255);
        }
    }
}
