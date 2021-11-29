using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Filters
{
    public enum FilterMode
    {
        NoFilter = 0,
        Negation = 1,
        Brightness = 2,
        Gamma = 3,
        Contrast = 4,
        Custom = 5
    }
}
