using GildedRose.Console.Items;
using GildedRose.Console.ProcessTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.ProcessTime
{
    [TestClass]
    public class PriceTests
    {
        [TestMethod]
        public void ShouldUpdatePriceAgedBrie()
        {
            AgedBrie item = new AgedBrie(10, 20);
            Price sut = new Price(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePriceElixirOfTheMongoose()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose(10, 20);
            Price sut = new Price(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePricePlus5DexterityVest()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 20);
            Price sut = new Price(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Price, 38M);
        }

        [TestMethod]
        public void ShouldUpdatePricePlus5DexterityVest_II()
        {
            Plus5DexterityVest item = new Plus5DexterityVest(10, 5);
            Price sut = new Price(item);

            sut.TimeRuns();
            Assert.AreEqual(item.Price, 9.5M);
        }
    }
}
