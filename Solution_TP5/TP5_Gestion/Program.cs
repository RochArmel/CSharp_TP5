using System;
using System.Windows.Forms;

namespace TP5_Gestion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmForm1());
        }
    }
}
