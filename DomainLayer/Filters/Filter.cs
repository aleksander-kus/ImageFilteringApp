using System.Drawing;

namespace DomainLayer.Filters
{
    public abstract class Filter
    {
        protected int[] function = new int[256];
        public int[] Function => function;
        public Color Transform(Color color) => 
            Color.FromArgb(function[color.R], function[color.G], function[color.B]);
    }
}
