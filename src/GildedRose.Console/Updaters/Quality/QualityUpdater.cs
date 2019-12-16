using GildedRose.Console.Items;

namespace GildedRose.Console.Updaters.Quality
{
    public abstract class QualityUpdater
    {
        public enum TimeRunsType
        {
            NonmodifierQualityUpdater = 0,
            RegularIncreaserQualityUpdater = 1,            
            DefaultQualityUpdater = 2
        }

        public TimeRunsType QualityTimeRuns { get; set; }

        public abstract void UpdateQuality(Item item);
    }
}
