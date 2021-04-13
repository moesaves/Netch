using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Models
{
    [TestClass]
    public class Mode
    {
        [TestMethod]
        public void Test()
        {
            Console.Write(new Netch.Models.Mode.ProcessMode.ProcessMode() { Remark = "114514" }.ToString());
        }
    }
}
