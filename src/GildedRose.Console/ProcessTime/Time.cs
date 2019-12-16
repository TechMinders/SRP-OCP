using GildedRose.Console.Items;
using System.Collections.Generic;

namespace GildedRose.Console.ProcessTime
{
    public class Time
    {        
        private IList<Item> _items;

        public Time(IList<Item> items) {
            _items = items;
        }

        public void Runs() {
            foreach (Item item in _items)
            {
                Quality quality = new Quality(item);
                quality.TimeRuns();

                SellIn sellIn = new SellIn(item);
                sellIn.TimeRuns();

                Price price = new Price(item);                      
                price.TimeRuns();                
            }
        }

    }
}
