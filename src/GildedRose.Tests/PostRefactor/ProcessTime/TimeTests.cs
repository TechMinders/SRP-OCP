using GildedRose.Console.Items;
using GildedRose.Console.ProcessTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Tests.PostRefactor.ProcessTime
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        public void ShouldUpdateTimeAgedBrie()
        {
            ElixirOfTheMongoose itemElixir = new ElixirOfTheMongoose(9, 21);
            AgedBrie itemBrie = new AgedBrie(10, 20);
            Plus5DexterityVest itemVest = new Plus5DexterityVest(11, 19);

            IList<Item> items = new List<Item> { itemElixir , itemBrie, itemVest};
            Time sut = new Time(items);

            sut.Runs();

            Assert.AreEqual(itemElixir.Price, 39.9M);
            Assert.AreEqual(itemElixir.SellIn, 8);
            Assert.AreEqual(itemElixir.Quality, 21);

            Assert.AreEqual(itemBrie.Price, 39.9M);
            Assert.AreEqual(itemBrie.SellIn, 9);
            Assert.AreEqual(itemBrie.Quality, 21);

            Assert.AreEqual(itemVest.Price, 34.2M);
            Assert.AreEqual(itemVest.SellIn, 10);
            Assert.AreEqual(itemVest.Quality, 18);
        }        
    }
}
