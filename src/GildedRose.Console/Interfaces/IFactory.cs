using GildedRose.Console.UpdaterFactory;

namespace GildedRose.Console.Interfaces
{
    public interface IFactory
    {
        CreatorBase Build(string productName);
    }
}