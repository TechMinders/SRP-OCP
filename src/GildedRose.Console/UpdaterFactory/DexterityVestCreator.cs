using GildedRose.Console.Interfaces;
using GildedRose.Console.Updater;

namespace GildedRose.Console.UpdaterFactory
{
    public class DexterityVestCreator : CreatorBase
    {
        public override IQualityUpdater FactoryMethod()
        {
            return new DexterityVestUpdater();
        }
    }
}