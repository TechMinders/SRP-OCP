using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Updaters.Quality
{
    [TestClass]
    public class DefaultQualityUpdaterTests
    {
        [TestMethod]
        public void ShouldUpdateQualityAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 19);
        }

        [TestMethod]
        public void ShouldUpdateQualityElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 19);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 19);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestBelowTwo()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 1);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 0);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestBelowZero()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 0);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 0);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestSellInOverOne()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 5);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 4);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestSellInBellowOne()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(0, 5);
            DefaultQualityUpdater sut = new DefaultQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 3);
        }
    }
}
