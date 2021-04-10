using System;
using System.Windows.Forms;

namespace Netch
{
    public static class Netch
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Global.MainForm = new Forms.MainForm());
        }
    }
}
