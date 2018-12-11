using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            IExceleration e = new Exelerator();
            e.CrossLimit += OnCross;

            e.Print(Strategy);
            Console.WriteLine("\r\n===============================");
            e.Print(c => c > 0.1 ? c - 0.1 : 1);
            Console.ReadKey();
        }

        private static double Strategy(double currentDelay)
        {
            if (currentDelay > 0.1)
                currentDelay -= 0.1;
            return currentDelay;
        }

        private static void OnCross(object sender, CrossDirection args)
        {
            Console.Write($" # {args} # ");
        }

        // TODO: write method that getting exceleration strategy from outside
        //       Step 2: whe duration < 0.3 sec notify (subscribe from main) 
        /*
          Example void Print(excelerationStrategy)
          {
            TimeSpan duration = TimeSpan.FromSeconds(0.5);
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(duration)
                duration = excelerationStrategy(i,duration);
                Console.Write("."); 
            }
            Console.WriteLine();
          }
        */
    }
}
