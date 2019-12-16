using System;
using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Price
{
    public class RegularIncreaserPriceUpdater : PriceUpdater
    {
        public RegularIncreaserPriceUpdater() {
            PriceTimeRuns = TimeRunsType.RegularIncreaserQualityUpdater;
        }

        public override void UpdatePrice(Item item)
        {
            item.Price = Math.Round(item.Quality * 1.9M, 2);
        }
    }
}
