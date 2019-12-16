using GildedRose.Console.Interfaces;

namespace GildedRose.Console.UpdaterFactory
{
    public abstract class CreatorBase
    {
        public abstract IQualityUpdater FactoryMethod();

        public void UpdateQuality(IItem item)
        {
            var product = this.FactoryMethod();

            product.Update(item);
        }
    }
}