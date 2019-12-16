using GildedRose.Console.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.Console.Updaters.Quality;

namespace GildedRose.Tests.PostRefactor.Updaters.Quality
{
    [TestClass]
    public class RegularIncreaserQuealityUpdaterTests
    {
        [TestMethod]
        public void ShouldUpdateQualityAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 21);
        }

        [TestMethod]
        public void ShouldUpdateQualityElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 21);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 21);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestSellInOverOne()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 5);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 6);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestSellInBellowOne()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(0, 5);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 7);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestQualityOver50()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 52);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 52);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestQuality50()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 50);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 50);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVestQuality49()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 49);
            RegularIncreaserQualityUpdater sut = new RegularIncreaserQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 50);
        }
    }
}
