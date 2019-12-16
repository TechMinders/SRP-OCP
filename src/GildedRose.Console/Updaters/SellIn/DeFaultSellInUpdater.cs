using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.SellIn
{
    public class DeFaultSellInUpdater : SellInUpdater
    {   
        public DeFaultSellInUpdater()
        {
            SellInTimeRuns = TimeRunsType.DeFaultSellInUpdater;
        }

        public override  void UpdateSellIn(Item item)
        {           
                item.SellIn--;
        }
    }
}