using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;

namespace Tests.Controllers.Mode
{
    [TestClass]
    public class TunController
    {
        [TestMethod]
        public void TestInterfaceList()
        {
            var list = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{list[i].GetIPProperties().GetIPv4Properties().Index}\t{list[i].Name}");
            }
        }
    }
}
