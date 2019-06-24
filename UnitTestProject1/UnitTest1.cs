using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInCircleNotInParabola()
        {
            Assert.AreEqual(7, Program.Area(0, 2));
        }

        [TestMethod]
        public void TestInCircleNotInParabola2()
        {
            Assert.AreEqual(7, Program.Area(0, 1.1));
        }
        [TestMethod]
        public void TestInCircleInParabola()
        {
            Assert.AreEqual(-1, Program.Area(0, 1));
        }
        [TestMethod]
        public void TestNotInCircleNotInParabola()
        {
            Assert.AreEqual(7, Program.Area(5, 0));
        }
        [TestMethod]
        public void TestNotInCircleInParabola()
        {
            Assert.AreEqual(7, Program.Area(0, -3));
        }
        [TestMethod]
        public void TestInCircleInParabola2()
        {
            Assert.AreEqual(-0.5, Program.Area(0, 0.5));
        }
    }
}
