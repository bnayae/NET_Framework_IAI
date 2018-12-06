using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollision
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicDevice m = new MagicDevice();
            ((IScreen)m).Print();
            ((IPrinter)m).Print();

            
            PrintScreen(m);
            PrintPrinter(m);

        }

        static void PrintPrinter(IPrinter printer)
        {
            Console.WriteLine("Printer....");
            printer.Print();
        }

        static void PrintScreen(IScreen screen)
        {
            Console.WriteLine("Screen....");
            screen.Print();
        }
    }
}
