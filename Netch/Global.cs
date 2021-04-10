using System.IO;
using System.Windows.Forms;

namespace Netch
{
    public static class Global
    {
        /// <summary>
        ///     版本号
        /// </summary>
        public static readonly string VerCode = "2.0.0";

        /// <summary>
        ///     主窗体
        /// </summary>
        public static Forms.MainForm MainForm;

        /// <summary>
        ///     日志记录
        /// </summary>
        public static Tools.Logger Logger = new Tools.Logger() { SavePath = Path.Combine(Application.StartupPath, "Netch.log") };
    }
}
