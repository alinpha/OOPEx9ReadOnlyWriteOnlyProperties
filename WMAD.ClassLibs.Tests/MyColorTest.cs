using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WMAD.ClassLibs.Tests
{
    [TestClass]
    public class MyColorTest
    {
        #region blue tests

        [TestMethod]
        public void Blue_Positive_Set_Min()
        {
            MyColor target = new MyColor();
            int expected = MyColor.MIN;
            target.Blue = expected;
            Assert.AreEqual(expected,target.Blue);
        }

        [TestMethod]
        public void Blue_Positive_Set_Max()
        {
            MyColor target = new MyColor();
            int expected = MyColor.MAX;
            target.Blue = expected;
            Assert.AreEqual(expected, target.Blue);
        }

        [TestMethod]
        public void Blue_Positive_Set_MinOutOfRange()
        {
            MyColor target = new MyColor();
            int expected = MyColor.DEFAULT;
            target.Blue = MyColor.MIN - 1;
            Assert.AreEqual(expected, target.Blue);
        }

        [TestMethod]
        public void Blue_Positive_Set_MaxOutOfRange()
        {
            MyColor target = new MyColor();
            int expected = MyColor.DEFAULT;
            target.Blue = MyColor.MAX + 1;
            Assert.AreEqual(expected, target.Blue);
        }

        #endregion

        #region green tests
        [TestMethod]
        public void Green_Positive_Set_Min()
        {
            MyColor target = new MyColor();
            int expected = MyColor.DEFAULT;
            target.Green = expected;
            Assert.AreEqual(expected, target.Green);
        }

        [TestMethod]
        public void Green_Positive_Set_Max()
        {
            MyColor target = new MyColor();
            int expected = MyColor.MAX;
            target.Green = expected;
            Assert.AreEqual(expected, target.Green);
        }

        [TestMethod]
        public void Green_Positive_Set_MinOutOfRange()
        {
            MyColor target = new MyColor();
            int expected = MyColor.DEFAULT;
            target.Green = MyColor.MIN - 1;
            Assert.AreEqual(expected, target.Green);
        }

        [TestMethod]
        public void Green_Positive_Set_MaxOutOfRange()
        {
            MyColor target = new MyColor();
            int expected = MyColor.DEFAULT;
            target.Green = MyColor.MAX + 1;
            Assert.AreEqual(expected, target.Green);
        }
        #endregion

        #region red tests
        [TestMethod]
        public void Red_Positive_Set_Min()
        {
            MyColor target = new MyColor();
            int expected = 0;
            target.Red = expected;
            Assert.AreEqual(expected, target.Red);
        }

        [TestMethod]
        public void Red_Positive_Set_Max()
        {
            MyColor target = new MyColor();
            int expected = 256;
            target.Red = expected;
            Assert.AreEqual(expected, target.Red);
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Red_Negative_Set_MinOutOfRange()
        {
            MyColor target = new MyColor();
            target.Red = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Red_Negative_Set_MaxOutOfRange()
        {
            MyColor target = new MyColor();
            target.Red = 257;
        }
        #endregion
    }
}
