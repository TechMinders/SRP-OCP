
using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Quality
{
    public class NonmodifierQualityUpdater : QualityUpdater
    {       
      
        public NonmodifierQualityUpdater() {
            QualityTimeRuns = TimeRunsType.NonmodifierQualityUpdater;  
        }

        public override void UpdateQuality(Item item)
        {
            item.Quality = item.Quality;
        }
    }
}
