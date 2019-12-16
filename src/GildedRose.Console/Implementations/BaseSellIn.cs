namespace GildedRose.Console
{
    internal class BaseSellIn : IUpdateSellIn
    {
        public void Update(Item item)
        {
            UpdateSellIn(item);
        }

        public void UpdateSellIn(Item item)
        {           
                item.SellIn--;
        }
    }
}