using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Utils
{
    [TestClass]
    public class GitHub
    {
        [TestMethod]
        public void TestRelease()
        {
            var list = Netch.Utils.GitHub.GetReleaseList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].VerCode);
            }
        }

        [TestMethod]
        public void TestHasUpdate()
        {
            Console.WriteLine(Netch.Utils.GitHub.HasUpdate());
        }
    }
}
