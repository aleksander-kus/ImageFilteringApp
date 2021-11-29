using PresentationLayer.ViewLoaders;
using System;
using System.Windows.Forms;

namespace PresentationLayer2
{

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ViewLoader loader = new ViewLoader();
            loader.LoadMainView();

            Application.Run(loader.LastLoadedForm);
        }
    }
}
