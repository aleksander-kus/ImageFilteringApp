namespace DomainLayer
{
    public class ColorHistograms
    {
        public int[] RHistogram { get; set; } = new int[256];
        public int[] GHistogram { get; set; } = new int[256];
        public int[] BHistogram { get; set; } = new int[256];

        public void Clear()
        {
            ClearHistogram(RHistogram);
            ClearHistogram(BHistogram);
            ClearHistogram(GHistogram);
        }

        private void ClearHistogram(int[] histogram)
        {
            for (int i = 0; i < histogram.Length; ++i)
                histogram[i] = 0;
        }
    }
}
