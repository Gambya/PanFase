using PanFase;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class PanFase
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }
    }
}
