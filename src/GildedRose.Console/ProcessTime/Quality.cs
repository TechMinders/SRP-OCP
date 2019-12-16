
using GildedRose.Console.Items;
using GildedRose.Console.Updaters.Quality;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ProcessTime
{
    public class Quality
    {       
        List<QualityUpdater> qualityUpdatersTypes = new List<QualityUpdater> { new NonmodifierQualityUpdater(), new RegularIncreaserQualityUpdater(), new DefaultQualityUpdater() };
        private Item _item;

        public Quality(Item item)
        {
            _item = item;
        }

        public void TimeRuns() {            

            foreach (QualityUpdater itemQuality in qualityUpdatersTypes)
            {
                if (_item.QualityTimeRuns == itemQuality.QualityTimeRuns)
                {
                    itemQuality.UpdateQuality(_item);
                }
            }
        }        
    }
}
