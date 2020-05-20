using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
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
<<<<<<< HEAD
            Application.Run(new QuanLyPhim());
=======
            Application.Run(new DemoForm());
>>>>>>> e35c67c6ab5a8dd09eff187c0a81f58ebf8998fa
        }
    }
}
