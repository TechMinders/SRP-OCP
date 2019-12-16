using GildedRose.Console.Interfaces;
using GildedRose.Console.Updater;

namespace GildedRose.Console.UpdaterFactory
{
    public class AgedBrieCreator: CreatorBase
    {
        public override IQualityUpdater FactoryMethod()
        {
            return new AgedBrieUpdater();
        }
    }
}