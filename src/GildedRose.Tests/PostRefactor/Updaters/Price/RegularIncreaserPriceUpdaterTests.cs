using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Price;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Updaters.Price
{
    [TestClass]
    public class RegularIncreaserPriceUpdaterTests
    {
        [TestMethod]
        public void ShouldUpdatePriceAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            RegularIncreaserPriceUpdater sut = new RegularIncreaserPriceUpdater();

            sut.UpdatePrice(item);
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePriceElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            RegularIncreaserPriceUpdater sut = new RegularIncreaserPriceUpdater();

            sut.UpdatePrice(item);
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePricePlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            RegularIncreaserPriceUpdater sut = new RegularIncreaserPriceUpdater();

            sut.UpdatePrice(item);
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePricePlus5DexterityVest_II()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 19);
            RegularIncreaserPriceUpdater sut = new RegularIncreaserPriceUpdater();

            sut.UpdatePrice(item);
            Assert.AreEqual(item.Price, 36.1M);
        }
    }
}

