using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Tests
{
    [TestClass()]
    public class Lab41Tests
    {

        [TestMethod()]
        public void GetFactorTest1()
        {
            Lab41 classTest = new Lab41("qwe");
            int except = 120;
            int act = classTest.GetFactor(5);
            Assert.IsTrue(act == except);
        }
        [TestMethod()]
        public void GetFactorTest2()
        {
            Lab41 classTest = new Lab41("qwe");
            int except = 24;
            int act = classTest.GetFactor(5);
            Assert.IsTrue(act != except);
        }

        [TestMethod()]
        public void CheckInArrTest1()
        {
            Lab41 classTest = new Lab41("qwe");
            bool except = false;

            bool act = classTest.CheckInArr(new string[] {"q", "e", "w"}, "e");
            Assert.IsTrue(act == except);
        }

        [TestMethod()]
        public void CheckInArrTest2()
        {
            Lab41 classTest = new Lab41("qwe");
            bool except = true;

            bool act = classTest.CheckInArr(new string[] { "q", "h", "w" }, "e");
            Assert.IsTrue(act == except);
        }

        [TestMethod()]
        public void MainFunctionTest()
        {
            Lab41 classTest = new Lab41("q_w");
            string[] expect = { "q w", "w q" };
            Assert.IsTrue(classTest == expect);
        }
    }
}