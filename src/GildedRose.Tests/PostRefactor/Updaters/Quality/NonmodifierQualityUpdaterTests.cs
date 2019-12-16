using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Updaters.Quality
{
    [TestClass]
    public class NonmodifierQualityUpdaterTests
    {
        [TestMethod]
        public void ShouldUpdateQualityAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            NonmodifierQualityUpdater sut = new NonmodifierQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 20);
        }

        [TestMethod]
        public void ShouldUpdateQualityElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            NonmodifierQualityUpdater sut = new NonmodifierQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 20);
        }

        [TestMethod]
        public void ShouldUpdateQualityPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            NonmodifierQualityUpdater sut = new NonmodifierQualityUpdater();

            sut.UpdateQuality(item);
            Assert.AreEqual(item.Quality, 20);
        }
    }
}
