using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    public class ColorSubscriber
    {
        public readonly ConsoleColor _color;
        public ColorSubscriber(ConsoleColor color)
        {
            _color = color;
        }

        public void Notify(string message, DateTimeOffset stamp)
        {
            Console.ForegroundColor = _color;
            DateTimeOffset localTime = stamp.ToLocalTime();
            Console.WriteLine($"{localTime:HH:mm:ss}: {message}");
            Console.ResetColor();
        }
    }
}
