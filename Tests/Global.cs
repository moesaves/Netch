using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Windows.Forms;

namespace Tests
{
    [TestClass]
    public class Global
    {
        [TestMethod]
        public void Test()
        {
            Console.WriteLine(Application.StartupPath);
        }

        [TestMethod]
        public void TestCurrent()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
