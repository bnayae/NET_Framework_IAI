using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cat : /*IDimentions*/ IDimensionPrintable
    {
        public int getHeight()
        {
            return 2;
        }

        public int getWidth()
        {
            return 40;
        }

        public void Print()
        {
            Console.WriteLine($"Miao !");
        }
    }
}
