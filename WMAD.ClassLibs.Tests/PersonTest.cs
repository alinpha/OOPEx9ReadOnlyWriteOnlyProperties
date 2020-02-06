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
    }
}
