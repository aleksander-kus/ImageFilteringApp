namespace DomainLayer.Filters
{
    public class CustomFilter : Filter
    {
        public CustomFilter(int[] function)
        {
            this.function = (int[])function.Clone();
        }
    }
}
