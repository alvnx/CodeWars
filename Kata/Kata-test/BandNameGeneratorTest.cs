using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTest
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        [TestMethod]
        public void BandNameGeneratorKnife()
        {
            var Generator = new BandNameGenerator();
            string input = "knife";
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

        [TestMethod]
        public void BandNameGeneratorSandlesandles()
        {
            var Generator = new BandNameGenerator();
            string input = "sandles";
            string expect = "Sandlesandles";
            Assert.AreEqual(expect, Generator.GenerateBandName(input));
        }

        [TestMethod]
        public void BandNameGeneratorBed()
        {
            var Generator = new BandNameGenerator();
            string input = "bed";
            string expect = "The Bed";
            Assert.AreEqual(expect, Generator.GenerateBandName(input));
        }
    }
}
