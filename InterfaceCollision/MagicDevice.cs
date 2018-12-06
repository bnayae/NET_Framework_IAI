using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollision
{
    public class MagicDevice : IPrinter, IScreen
    {
        public ConsoleColor Color { get; } = ConsoleColor.Gray;

        public int Width { get; } = 200;

        void IScreen.Print()
        {
            Console.WriteLine("Screen printing");
        }
         void IPrinter.Print()
        {
            Console.WriteLine("Printer printing");
        }
    }
}
