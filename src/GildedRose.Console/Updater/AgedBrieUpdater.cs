using GildedRose.Console.Interfaces;

namespace GildedRose.Console.Updater
{
    public class AgedBrieUpdater : IQualityUpdater
    {
        public IItem Update(IItem item)
        {
            item.SellIn -= 1;

            if (item.Quality < 50)
                item.Quality += 1;

            if (item.SellIn < 0 && item.Quality < 50)
                item.Quality += 1;

            return item;
        }
    }
}