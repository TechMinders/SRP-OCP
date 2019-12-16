using GildedRose.Console.Items;
using GildedRose.Console.ProcessTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.ProcessTime
{
    [TestClass]
    public class QualityTests
    {
        [TestMethod]
        public void ShouldUpdateQualityAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            Quality sut = new Quality(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Quality, 21);
        }

        [TestMethod]
        public void ShouldUpdateQualityElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            Quality sut = new Quality(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Quality, 20);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            Quality sut = new Quality(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Quality, 19);
        }
    }
}
