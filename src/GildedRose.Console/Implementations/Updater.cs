using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Updater
    {
        private List<IUpdate> Updaters;
        public Updater(IUpdateSellIn sellIn, IUpdateQuality quality, IUpdateprice price)
        {
            this.Updaters = new List<IUpdate>();
            Updaters.Add(sellIn);
            Updaters.Add(quality);
            Updaters.Add(price);
        }

        public void Update(Item item) {
            foreach (IUpdate u in Updaters) {
                u.Update(item);
            }
        
        }
    }
}