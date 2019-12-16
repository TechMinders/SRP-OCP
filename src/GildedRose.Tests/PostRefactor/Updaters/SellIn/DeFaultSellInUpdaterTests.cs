using GildedRose.Console.Items;
using GildedRose.Console.Updaters.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Updaters.SellIn
{
    [TestClass]
    public class DeFaultSellInUpdaterTests
    {
        [TestMethod]
        public void ShouldUpdateSellInAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            DeFaultSellInUpdater sut = new DeFaultSellInUpdater();

            sut.UpdateSellIn(item);
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            DeFaultSellInUpdater sut = new DeFaultSellInUpdater();

            sut.UpdateSellIn(item);
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            DeFaultSellInUpdater sut = new DeFaultSellInUpdater();

            sut.UpdateSellIn(item);
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInPlus5DexterityVest_II()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(2, 20);
            DeFaultSellInUpdater sut = new DeFaultSellInUpdater();

            sut.UpdateSellIn(item);
            Assert.AreEqual(item.SellIn, 1);
        }
    }
}
