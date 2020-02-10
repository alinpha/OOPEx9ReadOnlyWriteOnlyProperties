using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WMAD.ClassLibs.Tests
{
    [TestClass]
    public class MailCarrierTest
    {
        

        [TestMethod]
        public void EmailAlias_Positive_Set()
        {
            MailCarrier target = new MailCarrier();
            string expected = "aline.vetrov";
            PrivateObject pObj = new PrivateObject(target);
            target.EmailAlias = expected;
            Assert.AreEqual(expected, pObj.GetField("emailAlias"));
        }

        [TestMethod]
        [ExpectedException(typeof(DataException))]
        public void Name_Negative_Get()
        {
            MailCarrier target = new MailCarrier();
            string expected = target.Name;
        }

        [TestMethod]
        public void Name_Positive_Get()
        {
            MailCarrier target = new MailCarrier();
            target.EmailAlias = "aline.vetrov";
            string expected = "aline vetrov";
            Assert.AreEqual(expected, target.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(DataException))]
        public void EmailAddress_Negative_Get()
        {
            MailCarrier target = new MailCarrier();
            string expected = target.EmailAddress;
        }

        [TestMethod]
        public void EmailAddress_Positive_Get()
        {
            MailCarrier target = new MailCarrier();
            target.EmailAlias = "aline.vetrov";
            string expected = "aline.vetrov@gnb.ca";
            Assert.AreEqual(expected, target.EmailAddress);
        }
    }


}
