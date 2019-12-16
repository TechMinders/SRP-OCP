using GildedRose.Console.Updaters.Price;
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;

namespace GildedRose.Console.Items
{
    public abstract class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public decimal Price { get; set; }

        public QualityUpdater.TimeRunsType QualityTimeRuns { get; set; }

        public SellInUpdater.TimeRunsType SellInTimeRuns { get; set; }

        public PriceUpdater.TimeRunsType PriceTimeRuns { get; set; }
        

        public Item(string name, int sellIn, int quality) {
            QualityTimeRuns = QualityUpdater.TimeRunsType.NonmodifierQualityUpdater;
            SellInTimeRuns = SellInUpdater.TimeRunsType.DeFaultSellInUpdater;
            PriceTimeRuns = PriceUpdater.TimeRunsType.RegularIncreaserQualityUpdater;
            Quality = quality;
            SellIn = sellIn;
            Name = name;
        }
    }
}
