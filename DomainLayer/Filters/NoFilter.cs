namespace DomainLayer.Filters
{
    public class NoFilter : Filter
    {
        public NoFilter()
        {
            for (int i = 0; i < function.Length; ++i)
                function[i] = i;
        }
    }
}
