using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public static class UpdaterFactory
    {
        public static Updater GetUpdater(Item item) {
            
            if (item.Name.Contains("Aged Brie")) 
            {
                return new Updater(new BaseSellIn(), new AgedBrieQuality(), new BasePrice());
            }
            else return new Updater(new BaseSellIn(), new BaseQuality(), new BasePrice());


        }
    }
}
