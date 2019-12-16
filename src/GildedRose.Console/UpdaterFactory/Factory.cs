using GildedRose.Console.Interfaces;

namespace GildedRose.Console.UpdaterFactory
{
    public class Factory : IFactory
    {
        public CreatorBase Build(string productName)
        {
            if (productName == "+5 Dexterity Vest")
                return new DexterityVestCreator();

            if (productName == "Aged Brie")
                return new AgedBrieCreator();

            return new ElixirOfTheMongooseCreator();
        }
    }
}