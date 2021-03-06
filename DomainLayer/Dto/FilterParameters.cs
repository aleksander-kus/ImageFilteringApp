using DomainLayer.Filters;
using System.ComponentModel;
using System.Linq;

namespace DomainLayer.Dto
{
    public class FilterParameters : INotifyPropertyChanged
    {
        public bool[,] Selected { get; set; }
        private Filter filter;
        public Filter Filter
        {
            get => filter;
            set
            {
                if ((filter == null && value != null) || (value == null && filter != null) || !filter.Function.SequenceEqual(value.Function))
                {
                    filter = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Filter)));
                }
            }
        }

        private CurveMode curveMode = CurveMode.Normal;
        public CurveMode CurveMode
        {
            get => curveMode;
            set
            {
                if(curveMode != value)
                {
                    curveMode = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurveMode)));
                }
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e) =>
            PropertyChanged?.Invoke(this, e);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
