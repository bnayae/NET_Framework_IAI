using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _008_Timer_Delegate
{
    class Program
    {
        private static Timer _tmr;
        static void Main(string[] args)
        {
            TimerCallback callback = OnTime1;
            callback += OnTime2;
            _tmr = new Timer(callback , "Hi", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            Console.ReadKey();
        }

        private static void OnTime1(object state)
        {
            Console.WriteLine($"1) {state}");
        }

        private static void OnTime2(object state)
        {
            Console.WriteLine($"2) {state}");
        }
    }
}
