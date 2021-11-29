using System.ComponentModel;
using System.Drawing;

namespace DomainLayer
{
    public class HistogramParameters : INotifyPropertyChanged
    {
        private Bitmap bitmap;
        public Bitmap Bitmap
        {
            get => bitmap;
            set
            {
                bitmap = value;
                OnPropertyChanged(nameof(Bitmap));
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);

        protected void OnPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
