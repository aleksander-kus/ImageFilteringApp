namespace DomainLayer.Filters
{
    public class BrightnessFilter : Filter
    {
        public BrightnessFilter(int beginPoint)
        {
            if(beginPoint < 0)
            {
                beginPoint = -beginPoint;
                for (int i = beginPoint; i < function.Length; ++i)
                    function[i] = i - beginPoint;
            }
            else
            {
                int i = 0;
                for (; i < 256 - beginPoint; ++i)
                    function[i] = beginPoint + i;
                for (; i < function.Length; ++i)
                    function[i] = 255;
            }
        }
    }
}
