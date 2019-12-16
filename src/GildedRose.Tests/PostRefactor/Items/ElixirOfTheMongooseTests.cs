using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Price;
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Items
{
    [TestClass]
    public class ElixirOfTheMongooseTests
    {
        [TestMethod]
        public void ShouldNew()
        {
            ElixirOfTheMongoose sut = new ElixirOfTheMongoose(15, 22);

            Assert.AreEqual(sut.QualityTimeRuns, QualityUpdater.TimeRunsType.NonmodifierQualityUpdater);
            Assert.AreEqual(sut.SellInTimeRuns, SellInUpdater.TimeRunsType.DeFaultSellInUpdater);
            Assert.AreEqual(sut.PriceTimeRuns, PriceUpdater.TimeRunsType.RegularIncreaserQualityUpdater);
            Assert.AreEqual(sut.Quality, 22);
            Assert.AreEqual(sut.SellIn, 15);
            Assert.AreEqual(sut.Price, 0);
        }
    }
}
