using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class AgedBrieQuality : ReverseQuality
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
            if (item.Quality < 50 && item.SellIn <= 0)
            {
                item.Quality++;
            }

        }
    }
}
