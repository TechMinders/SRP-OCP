using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Price;
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PostRefactor.Items
{
    [TestClass]
    public class Plus5DexterityVestTests
    {
        [TestMethod]
        public void ShouldNew()
        {
            Plus5DexterityVest sut = new Plus5DexterityVest(10, 20);            
            
            Assert.AreEqual(sut.QualityTimeRuns, QualityUpdater.TimeRunsType.DefaultQualityUpdater);
            Assert.AreEqual(sut.SellInTimeRuns, SellInUpdater.TimeRunsType.DeFaultSellInUpdater);
            Assert.AreEqual(sut.PriceTimeRuns, PriceUpdater.TimeRunsType.RegularIncreaserQualityUpdater);
            Assert.AreEqual(sut.Quality , 20);
            Assert.AreEqual(sut.SellIn, 10);
            Assert.AreEqual(sut.Price, 0);
        }
    }
}
