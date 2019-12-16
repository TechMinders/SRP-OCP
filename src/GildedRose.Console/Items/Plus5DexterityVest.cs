
using GildedRose.Console.Updaters.Quality;
using GildedRose.Console.Updaters.SellIn;

namespace GildedRose.Console.Items
{
    public class Plus5DexterityVest : Item
    {
        const string _name = "+5 Dexterity Vest";
        public Plus5DexterityVest(int SellIn, int Quality) : base(_name, SellIn, Quality)
        {
            QualityTimeRuns = QualityUpdater.TimeRunsType.DefaultQualityUpdater;            
        }
    }
}
