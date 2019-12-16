using GildedRose.Console.Items;
using GildedRose.Console.ProcessTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.ProcessTime
{
    [TestClass]
    public class SellInTests
    {
        [TestMethod]
        public void ShouldUpdateSellInAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            SellIn sut = new SellIn(item);

            sut.TimeRuns();
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            SellIn sut = new SellIn(item);

            sut.TimeRuns();
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInPlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            SellIn sut = new SellIn(item);

            sut.TimeRuns();
            Assert.AreEqual(item.SellIn, 9);
        }

        [TestMethod]
        public void ShouldUpdateSellInPlus5DexterityVest_II()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(8, 20);
            SellIn sut = new SellIn(item);

            sut.TimeRuns();
            Assert.AreEqual(item.SellIn, 7);
        }
    }
}
