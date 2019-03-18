using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECommerce.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();
            int s = c.Sum(2, 3);

            Assert.AreEqual(5, s);
        }
    }
}
