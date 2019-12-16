using GildedRose.Console;
using GildedRose.Console.Items;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PreRefactor
{
    [TestClass]
    public class UpdateQualityWithStandardItemInDateShould
    {
        private readonly Program target = new Program();
        private readonly Item testItem;

        public UpdateQualityWithStandardItemInDateShould()
        {
            testItem = new Plus5DexterityVest(10, 20);
            //testItem = new Item
            //{
            //    Name = "+5 Dexterity Vest",
            //    SellIn = 10,
            //    Quality = 20
            //};

            target.Items = new List<Item> { testItem };
        }

        [TestMethod]
        public void DecreaseRemainingDays()
        {
            target.TimeRuns();

            Assert.AreEqual(testItem.SellIn, 9);
        }

        [TestMethod]
        public void DecreaseQuality()
        {
            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 19);
            Assert.AreEqual(testItem.Price, 36.1M);
        }
    }
}