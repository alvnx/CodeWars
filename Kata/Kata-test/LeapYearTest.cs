using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear
{

    [TestClass]
    public class LeapYear
    {
        private readonly LeapYear _kata = new LeapYear();

        [TestMethod]
        public void TestLeapYear2001()
        {
            int input = 2001;
            string result = _kata.IsLeapYear(input);
            Assert.AreEqual(input + " is a typical common year", result);
        }

        [TestMethod]
        public void TestLeapYear1996()
        {
            int input = 1996;
            string result = _kata.IsLeapYear(input);
            Assert.AreEqual(input + " is a typical leap year", result);
        }

        [TestMethod]
        public void TestLeapYear2002()
        {
            int input = 2002;
            string result = _kata.IsLeapYear(input);
            Assert.AreEqual(input + " is a typical common year", result);
        }

        [TestMethod]
        public void TestLeapYear1900()
        {
            int input = 1900;
            string result = _kata.IsLeapYear(input);
            Assert.AreEqual(input + " is an atypical common year", result);
        }

        [TestMethod]
        public void TestLeapYear2000()
        {
            int input = 2000;
            string result = _kata.IsLeapYear(input);
            Assert.AreEqual(input + " is an atypical leap year", result);
        }
    }
}
