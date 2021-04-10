using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Utils
{
    [TestClass]
    public class UpdateChecker
    {
        [TestMethod]
        public void TestRelease()
        {
            var list = Netch.Utils.UpdateChecker.GetRelease();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].VerCode);
            }
        }
    }
}
