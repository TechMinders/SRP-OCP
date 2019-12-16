using System;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public decimal Price => Math.Round(this.Quality * 1.9M, 2);
    }
}