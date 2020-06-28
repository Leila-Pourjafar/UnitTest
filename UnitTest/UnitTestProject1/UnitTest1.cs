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
            string strSource = null;
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: string.Empty, actual: strActual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string strSource = "";
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: string.Empty, actual: strActual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            string strSource = " ";
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: string.Empty, actual: strActual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string strSource = "Sara jafari";
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: "Web Developer", actual: strActual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string strSource = " Sara jafari ";
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: "Sara jafari", actual: strActual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string strSource = "  Sara   jafari  ";
            string strActual = WebApplicationUnitTest.Helper.Utility.FixText(strSource);
            Assert.AreEqual(expected: "Sara jafari", actual: strActual);
        }
    }
}
