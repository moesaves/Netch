using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tests.Tools
{
    [TestClass]
    public class Logger
    {
        [TestMethod]
        public void Test()
        {
            Netch.Global.Logger.SavePath = Path.Combine(Directory.GetCurrentDirectory(), "Netch.log");
            Netch.Global.Logger.Info("Hello");
        }
    }
}
