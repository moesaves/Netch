using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Netch
{
    public static class Netch
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (var mutex = new Mutex(false, "Global\\Netch"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    Environment.Exit(1);
                }

                if (args.Contains("-d"))
                {
                    if (!NativeMethods.AttachConsole(unchecked((uint)-1)))
                    {
                        NativeMethods.AllocConsole();
                    }
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(Global.MainForm = new Forms.MainForm());
            }
        }
    }
}
