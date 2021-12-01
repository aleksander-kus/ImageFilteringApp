using System;

namespace DomainLayer.Filters
{
    public class GammaFilter : Filter
    {
        public GammaFilter(double gamma)
        {
            for (int i = 0; i < function.Length; ++i)
                function[i] = (int)Math.Round(Math.Pow(i / 255.0, 1.0/gamma) * 255);
        }
    }
}
