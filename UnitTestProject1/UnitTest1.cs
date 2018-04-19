using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cl = new ClassLibrary1.Class1();
            Assert.AreEqual(cl.Method1(2, 2), 4);
        }
    }
}
