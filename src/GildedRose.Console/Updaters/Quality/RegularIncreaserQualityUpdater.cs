using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Quality
{
    public class RegularIncreaserQualityUpdater : QualityUpdater
    {        
               
        public RegularIncreaserQualityUpdater()
        {
            QualityTimeRuns = TimeRunsType.RegularIncreaserQualityUpdater;
        }

        public override void UpdateQuality(Item item)
        {

            if (item.Quality < 49)
            {
                if (item.SellIn > 0)
                {
                    item.Quality++;
                }
                else
                {
                    item.Quality = item.Quality + 2;

                }
            }
            else if (item.Quality == 49)
            {

                item.Quality = 50;
            }
        }



    }

}
