namespace GildedRose.Console
{
    public abstract class ReverseQuality : IUpdateQuality
    {
        public void Update(Item item)
        {
            UpdateQuality(item);
        }

        public virtual void UpdateQuality(Item item)
        {
            if (item.Quality < 50 && item.SellIn > 0) {
                item.Quality++;
            }
        }
    }
}