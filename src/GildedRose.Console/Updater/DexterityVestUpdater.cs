using GildedRose.Console.Interfaces;

namespace GildedRose.Console.Updater
{
    public class DexterityVestUpdater : IQualityUpdater
    {
        public IItem Update(IItem item)
        {
            item.SellIn -= 1;

            if (item.Quality > 0)
                item.Quality -= 1;

            if (item.SellIn < 0 && item.Quality > 0)
                item.Quality -= 1;

            return item;
        }
    }
}