namespace GildedRose.Console
{
    internal class BasePrice : IUpdateprice
    {
        public void Update(Item item)
        {
            UpdatePrice(item);
        }

        public void UpdatePrice(Item item)
        {
            item.Price = System.Math.Round(item.Quality * 1.9M, 2);
        }
    }
}