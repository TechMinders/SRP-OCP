using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Quality
{
    public class DefaultQualityUpdater : QualityUpdater
    {              

        public DefaultQualityUpdater()
        {
            QualityTimeRuns = TimeRunsType.DefaultQualityUpdater;
        }

        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 1)
            {
                if (item.SellIn > 0)
                {
                    item.Quality--;
                }
                else
                {
                    item.Quality = item.Quality - 2;
                }
            }
            else
            {
                item.Quality = 0;
            }        

        }        
    }
}