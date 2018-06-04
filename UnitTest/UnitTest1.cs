using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnoghtsAndCrosses;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            char[] testArray = { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*' };
            Game.Board(testArray);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int flag = 5;
            flag = Game.CheckWin();
        }

        [TestMethod]
        public void TestMethod3()
        {
            int flag = 1;
            flag = Game.CheckWin();
        }
    }
}
