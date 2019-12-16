using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Price
{
    public abstract class PriceUpdater
    {
        public enum TimeRunsType
        {            
            RegularIncreaserQualityUpdater = 0         
        }

        public TimeRunsType PriceTimeRuns { get; set; }

        public abstract void UpdatePrice(Item item);
    }
}
