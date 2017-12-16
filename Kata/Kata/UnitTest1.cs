using System;
using KataProd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BandNameGeneratorKnife()
        {
            var Generator =new BandNameGenerator();
            string input = "Knife";
            string expect = "The Knife";
            Assert.AreEqual(expect, Generator.GenerateBandName(input));
        }

        [TestMethod]
        public void BandNameGeneratorTartart()
        {
            var Generator = new BandNameGenerator();
            string input = "tart";
            string expect = "Tartart";
            Assert.AreEqual(expect, Generator.GenerateBandName(input));
        }


    }
}
