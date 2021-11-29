using PresentationLayer.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;
        public MainView()
        {
            InitializeComponent();
        }

        public int CanvasWidth => throw new NotImplementedException();

        public int CanvasHeight => throw new NotImplementedException();

        public Bitmap CanvasImage => throw new NotImplementedException();

        public MainPresenter Presenter { set => presenter = value; }

        public void RedrawCanvas()
        {
            throw new NotImplementedException();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
