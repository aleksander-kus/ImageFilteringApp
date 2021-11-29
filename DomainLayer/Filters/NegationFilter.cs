namespace DomainLayer.Filters
{
    public class NegationFilter : Filter
    {
        public NegationFilter()
        {
            for (int i = 0; i < function.Length; ++i)
                function[i] = 255 - i;
        }
    }
}
