using GildedRose.Console;
using System.Collections.Generic;
using GildedRose.Console.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PreRefactor
{
    [TestClass]
    public class UpdateQualityWithAgedBrieShould
    {        
        private readonly Program target = new Program();
        private Item testItem;

        [TestMethod]
        public void DecreaseRemainingDays()
        {
            testItem = new AgedBrie(10, 20);

            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.SellIn, 9);
            Assert.AreEqual(testItem.Price, 39.9M);
        }

        [TestMethod]
        public void IncreaseQualityWhenBelowFifty()
        {
            testItem = new AgedBrie(10, 49);
            //testItem = new Item
            //{
            //    Name = AGED_BRIE,
            //    SellIn = 10,
            //    Quality = 49
            //};

            target.Items = new List<Item> { testItem };

            target.TimeRuns();
                        
            Assert.AreEqual(testItem.Quality, 50);
        }

        [TestMethod]
        public void LimitQualityToFifty()
        {
            testItem = new AgedBrie(10, 50);
            //testItem = new Item
            //{
            //    Name = AGED_BRIE,
            //    SellIn = 10,
            //    Quality = 50
            //};

            target.Items = new List<Item> { testItem };

            target.TimeRuns();
                        
            Assert.AreEqual(testItem.Quality, 50);
        }

        [TestMethod]
        public void IncreaseQualityTwiceAsFastAfterSaleDeadline()
        {
            // Note: Case discovered during characterisation
            testItem = new AgedBrie(0, 48);
            //testItem = new Item
            //{
            //    Name = AGED_BRIE,
            //    SellIn = 0,
            //    Quality = 48
            //};

            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 50);
        }

        [TestMethod]
        public void LimitQualityToFiftyWhenRateHasDoubled()
        {
            // Note: Case discovered during characterisation
            testItem = new AgedBrie(0, 49);
            //testItem = new Item
            //{
            //    Name = AGED_BRIE,
            //    SellIn = 0,
            //    Quality = 49
            //};

            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 50);
        }
    }
}