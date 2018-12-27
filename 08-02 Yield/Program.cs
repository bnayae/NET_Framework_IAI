using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Foo();

            foreach (var item in f)
            {
                Console.WriteLine(item);
                if (item == 2)
                    break;
            }
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
