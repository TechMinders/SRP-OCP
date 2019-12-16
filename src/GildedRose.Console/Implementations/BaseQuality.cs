namespace GildedRose.Console
{
    internal class BaseQuality : IUpdateQuality
    {
        public void Update(Item item)
        {
            UpdateQuality(item);
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0) {
                item.Quality--;
                if (item.SellIn <= 0&& item.Quality > 0)
                    item.Quality--;
            }
            
        }
    }
}