using GildedRose.Console.Interfaces;
using GildedRose.Console.Updater;

namespace GildedRose.Console.UpdaterFactory
{
    public class ElixirOfTheMongooseCreator: CreatorBase
    {
        public override IQualityUpdater FactoryMethod()
        {
            return new ElixirOfTheMongooseUpdater();
        }
    }
}