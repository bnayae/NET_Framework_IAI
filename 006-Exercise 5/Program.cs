using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2};
            int idx = Array.IndexOf(arr, 2);

            Foo f = new Foo();
            string s = f[4];
            Console.WriteLine($"4 = {s}");
            f[2] = "X"; // 2 is taken from the _index

            Console.WriteLine();
            foreach (string item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            IEnumerable<int> e = f.GetIndexs();
            foreach (int item in e)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
