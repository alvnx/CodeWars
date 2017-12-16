using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataProd;

namespace Kata
{
    [TestClass]
    public class CountingDuplicatesTest
    {
        [TestMethod]
        public void CountingDuplicate_abcde()
        {
            var Counter = new CountingDuplicates();
            string input = "abcde";
            int expect = 0;
            Assert.AreEqual(expect, Counter.Calculator(input));
        }

        [TestMethod]
        public void CountingDuplicate_aabbcde()
        {
            var Counter = new CountingDuplicates();
            string input = "aabbcde";
            int expect = 2;
            Assert.AreEqual(expect, Counter.Calculator(input));
        }

        [TestMethod]
        public void CountingDuplicate_aabBcde()
        {
            var Counter = new CountingDuplicates();
            string input = "aabBcde";
            int expect = 2;
            Assert.AreEqual(expect, Counter.Calculator(input));
        }
    }
}
