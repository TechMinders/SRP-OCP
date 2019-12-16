using GildedRose.Console.Items;
using GildedRose.Console.Updaters.SellIn;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ProcessTime
{
    public class SellIn
    {

        List<SellInUpdater> sellInUpdatersTypes = new List<SellInUpdater> {new DeFaultSellInUpdater()};
        private Item _item;

        public SellIn(Item item)
        {
            _item = item;
        }

        public void TimeRuns()
        {                       

            foreach (SellInUpdater itemQuality in sellInUpdatersTypes)
            {
                if (_item.SellInTimeRuns == itemQuality.SellInTimeRuns)
                {
                    itemQuality.UpdateSellIn(_item);
                }
            }
        }
    }
}
