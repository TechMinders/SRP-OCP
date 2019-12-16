using GildedRose.Console.Items;
using GildedRose.Console.ProcessTime;
using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {                
                Items = new List<Item>
                                          {
                                              new Plus5DexterityVest (10, 20),
                                              new AgedBrie (2,  0),
                                              new ElixirOfTheMongoose (5,  7)                                              
                                          }

            };

            app.TimeRuns();

            System.Console.ReadKey();

        }


        public void TimeRuns()
        {           
            Time time = new Time(Items);
            time.Runs();
        }
    }   
}

