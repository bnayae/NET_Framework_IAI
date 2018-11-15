using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            new Item();
            for (int i=0; i < 100; ++i)
            {
                new Item();
            }

            new Item();
            new Item();

            Item[] arr = new Item[] { new Item(), new Item() };
            int[] myNumbers = { 5, 4, 3, 2, 1 };

            Array.Sort(myNumbers);

            Item[] arr2 = new Item[300];
            for (int j = 0; j < 300; j++)
            {
                arr2[j] = new Item();
            }
            Console.WriteLine(Item.Count);
        }
    }
}
