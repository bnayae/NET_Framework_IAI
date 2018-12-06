using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Square : /*IDimentions*/ IDimensionPrintable
    {
        public int Z { get; set; }
        public Square(int x)
        {
            Z = x;
        }
        public int getHeight()
        {
            return Z;
        }

        public int getWidth()
        {
            return Z;
        }

        public void Print()
        {
            Console.WriteLine($"Square:: {Z}x{Z}");
        }
    }
    
}
