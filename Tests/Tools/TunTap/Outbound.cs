using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Tools.TunTap
{
    [TestClass]
    public class Outbound
    {
        [TestMethod]
        public void Test()
        {
            var outbound = new Netch.Tools.TunTap.Outbound();
            if (!outbound.Get())
            {
                Console.WriteLine("Get Failed");
                return;
            }

            Console.WriteLine(outbound.Index);
            Console.WriteLine(outbound.Address);
            Console.WriteLine(outbound.Netmask);
            Console.WriteLine(outbound.Gateway);
        }
    }
}
