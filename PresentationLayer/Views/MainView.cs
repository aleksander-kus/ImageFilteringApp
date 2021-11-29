using PresentationLayer.Presenters;
using PresentationLayer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;
        private readonly Image defaultImage;
        public MainView()
        {
            InitializeComponent();
            // Default image source: https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Earth_Western_Hemisphere_transparent_background.png/1200px-Earth_Western_Hemisphere_transparent_background.png
            defaultImage = Resources.earth;
        }

        public int CanvasWidth => pictureBox1.Width;

        public int CanvasHeight => pictureBox1.Height;


        public MainPresenter Presenter { set => presenter = value; }
        public Image CanvasImage { set => pictureBox1.Image = value; }

        public Image DefaultImage => defaultImage;

        public void RedrawCanvas() => pictureBox1.Invalidate();

        private void MainView_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.plsDo();
            histogramView1.Refresh();
        }
    }
}
