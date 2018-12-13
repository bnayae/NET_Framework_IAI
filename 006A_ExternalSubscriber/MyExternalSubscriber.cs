using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006A_ExternalSubscriber
{
    public class MyExternalSubscriber
    {
        public void OnMessageArrived(string str,DateTimeOffset dt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine($"HELLO ! {str}");
            Console.ResetColor();
        }
    }
}
