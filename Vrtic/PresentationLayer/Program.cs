using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //Application.Run(new Vaspitac());
            //Application.Run(new Deca());
            //Application.Run(new Seminar());
            //Application.Run(new FormaSobe());
            //Application.Run(new Izostanci());
           // Application.Run(new Oblasti());
        }
    }
}
