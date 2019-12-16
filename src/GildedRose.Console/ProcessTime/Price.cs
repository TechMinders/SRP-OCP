using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Price;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ProcessTime
{
    public class Price
    {
        List<PriceUpdater> priceUpdaterTypes = new List<PriceUpdater> {new RegularIncreaserPriceUpdater()};
        private Item _item;

        public Price(Item item)
        {
            _item = item;
        }

        public void TimeRuns()
        {

            foreach (PriceUpdater itemPrice in priceUpdaterTypes)
            {
                if (_item.PriceTimeRuns == itemPrice.PriceTimeRuns)
                {
                    itemPrice.UpdatePrice(_item);
                }
            }
        }
    }
}
