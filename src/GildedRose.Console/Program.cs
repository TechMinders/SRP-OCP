using System;
using System.Collections.Generic;
using GildedRose.Console.Interfaces;
using GildedRose.Console.UpdaterFactory;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;

        static void Main(string[] args)
        {

            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}
                }
            };

            app.UpdateQuality();

            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            IFactory factory = new Factory();

            foreach (var item in Items)
            {
                var creatorBase = factory.Build(item.Name);
                creatorBase.UpdateQuality(item);
            }
        }
    }
}
