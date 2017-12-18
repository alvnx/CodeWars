using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace DeadAntsTest
{   
    [TestClass]
    public class DeadAntsTest
    {
        [TestMethod]
        public void DeadAntsCounter()
        {
            var CountDeadAnts = new DeadAnts();
            string input = "ant ant ant ant";
            int expect = 0;
            Assert.AreEqual(expect, CountDeadAnts.DeadAntsCount(input));
        }

        [TestMethod]
        public void DeadAntsCounter_null()
        {
            var CountDeadAnts = new DeadAnts();
            string input = null;
            int expect = 0;
            Assert.AreEqual(expect, CountDeadAnts.DeadAntsCount(input));
        }

        [TestMethod]
        public void DeadAntsCounter_2()
        {
            var CountDeadAnts = new DeadAnts();
            string input = "ant anantt aantnt";
            int expect = 2;
            Assert.AreEqual(expect, CountDeadAnts.DeadAntsCount(input));
        }

        [TestMethod]
        public void DeadAntsCounter_3()
        {
            var CountDeadAnts = new DeadAnts();
            string input = "ant ant .... a nt";
            int expect = 1;
            Assert.AreEqual(expect, CountDeadAnts.DeadAntsCount(input));
        }
    }
}
