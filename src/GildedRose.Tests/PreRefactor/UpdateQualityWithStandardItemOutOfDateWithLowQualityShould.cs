using GildedRose.Console;
using GildedRose.Console.Items;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.PreRefactor
{
    [TestClass]
    public class UpdateQualityWithStandardItemOutOfDateWithLowQualityShould
    {        
        private readonly Program target = new Program();
        private Item testItem;

        [TestMethod]
        public void DecreaseQualityOfTwoToZero()
        {
            testItem = new Plus5DexterityVest(0, 1);
            //testItem = new Item { SellIn = 0, Quality = 1, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 0);
        }

        [TestMethod]
        public void DecraseQualityOnlyToZero()
        {
            testItem = new Plus5DexterityVest(0, 1);
            //testItem = new Item { SellIn = 0, Quality = 1, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 0);
        }

        [TestMethod]
        public void DisallowNegativeQuality()
        {
            testItem = new Plus5DexterityVest(0, 0);
            //testItem = new Item { SellIn = 0, Quality = 0, Name = DEXTERITY_VEST, };
            target.Items = new List<Item> { testItem };

            target.TimeRuns();

            Assert.AreEqual(testItem.Quality, 0);
            Assert.AreEqual(testItem.Price, 0);
        }
    }
}