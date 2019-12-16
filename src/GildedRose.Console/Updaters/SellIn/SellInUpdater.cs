using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.SellIn
{
    public abstract class SellInUpdater
    {
        public enum TimeRunsType
        {         
            DeFaultSellInUpdater = 0
        }

        public TimeRunsType SellInTimeRuns { get; set; }

        public abstract void UpdateSellIn(Item item);
    }
}
