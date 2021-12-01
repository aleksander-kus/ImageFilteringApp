using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int f(int x) => (int)(255 / (255.0 - 2 * beginPoint) * x - 255.0 * beginPoint / (255.0 - 2 * beginPoint));
            for (int i = beginPoint; i < 255 - beginPoint; ++i)
                function[i] = f(i);
        }
    }
}
