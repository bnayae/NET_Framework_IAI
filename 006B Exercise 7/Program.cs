using System;
using System.Collections.Generic;
using System.Text;

namespace _005_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWrapper w1 = "Hello";
            w1 += " World";
            w1++;

            Console.WriteLine(w1);
            try
            {
                StringWrapper w2 = w1 + null;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
