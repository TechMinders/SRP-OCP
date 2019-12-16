using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Price;
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Items
{
    [TestClass]
    public class AgedBrieTests
    {
        [TestMethod]
        public void ShouldNew()
        {
            AgedBrie sut = new AgedBrie(9, 21);

            Assert.AreEqual(sut.QualityTimeRuns, QualityUpdater.TimeRunsType.RegularIncreaserQualityUpdater);
            Assert.AreEqual(sut.SellInTimeRuns, SellInUpdater.TimeRunsType.DeFaultSellInUpdater);
            Assert.AreEqual(sut.PriceTimeRuns, PriceUpdater.TimeRunsType.RegularIncreaserQualityUpdater);
            Assert.AreEqual(sut.Quality, 21);
            Assert.AreEqual(sut.SellIn, 9);
            Assert.AreEqual(sut.Price, 0);
        }
    }
}
