using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Utils
{
    [TestClass]
    public class HTTP
    {
        [TestMethod]
        public void Test()
        {
            Console.WriteLine(Netch.Utils.HTTP.GetString("https://www.baidu.com"));
        }
    }
}
