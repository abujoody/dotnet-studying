using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task4_2
{
    static class Program
    {
	//Test changes to check diff tool work

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
