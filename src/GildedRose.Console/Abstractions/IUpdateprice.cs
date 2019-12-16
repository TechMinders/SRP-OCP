using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public interface IUpdateprice : IUpdate
    {
        void UpdatePrice(Item item);
    }
}
