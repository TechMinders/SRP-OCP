using GildedRose.Console;
using GildedRose.Console.Items;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PreRefactor
{
    [TestClass]
    public class UpdateQualityWithStandardItemOutOfDateShould
    {
        private readonly Program target = new Program();
        private readonly Item testItem;

        public UpdateQualityWithStandardItemOutOfDateShould()
        {
            testItem = new Plus5DexterityVest(0, 20);
            //testItem = new Item
            //{
            //    Name = "+5 Dexterity Vest",
            //    SellIn = 0,
            //    Quality = 20
            //};

            target.Items = new List<Item> { testItem };
        }

        [TestMethod]
        public void DecreaseRemainingDays()
        {
            target.TimeRuns();

            Assert.AreEqual(testItem.SellIn, -1);
        }

        [TestMethod]
        public void DecreaseQualityTwiceAsFast()
        {
            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 18);
            Assert.AreEqual(testItem.Price, 34.2M);
        }
    }
}