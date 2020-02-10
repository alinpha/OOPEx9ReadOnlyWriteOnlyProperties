using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WMAD.ClassLibs.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void AgeTest_Positive()
        {
            Person target = new Person();

            //birth month has passed
            target.DateOfBirth = DateTime.Now.AddYears(-50).AddMonths(-1);
            Assert.AreEqual(50, target.Age);

            //birthday is one month away
            target.DateOfBirth = DateTime.Now.AddYears(-50).AddMonths(1);
            Assert.AreEqual(49, target.Age);

            //birthday yesterday
            target.DateOfBirth = DateTime.Now.AddYears(-50).AddDays(-1);
            Assert.AreEqual(50, target.Age);

            //birthday one day away
            target.DateOfBirth = DateTime.Now.AddYears(-50).AddDays(1);
            Assert.AreEqual(49, target.Age);

            //birthday is today
            target.DateOfBirth = DateTime.Now.AddYears(-50);
            Assert.AreEqual(50, target.Age);
        }

        /// <summary>
        /// write only prop tests must  always use private object
        /// </summary>
        [TestMethod]
        public void DateOfBirth_Positive_Set()
        {
            Person target = new Person();
            PrivateObject pObj = new PrivateObject(target);
            DateTime expected = Convert.ToDateTime("December 19, 1980");
            target.DateOfBirth = expected;
            Assert.AreEqual(expected,pObj.GetField("dateOfBirth"));
        }

        [TestMethod]
        public void LaidOff_Positive_Set()
        {
            Person target = new Person();
            PrivateObject pObj = new PrivateObject(target);
            bool expected = true;
            target.LaidOff = expected;
            Assert.AreEqual(expected, pObj.GetField("laidOff"));
        }
    }
}
