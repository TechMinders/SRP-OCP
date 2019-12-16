
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;

namespace GildedRose.Console.Items
{
    public class AgedBrie: Item
    {
        const string _name = "Aged Brie";
        public AgedBrie(int SellIn, int Quality) : base(_name, SellIn, Quality)
        {
            QualityTimeRuns = QualityUpdater.TimeRunsType.RegularIncreaserQualityUpdater;            
        }
    }
}
