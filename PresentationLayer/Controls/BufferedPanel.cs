using System.Windows.Forms;

namespace PresentationLayer.Controls
{
    public partial class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
