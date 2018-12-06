using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rect : /*IDimentions*/ IDimensionPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Rect(int x , int y)
        {
            X = x;
            Y = y;
        }
        public int getHeight()
        {
            return Y;
        }

        public int getWidth()
        {
            return X;
        }

        public void Print()
        {
            Console.WriteLine($"Rect:: {X}x{Y}");
        }
    }
}
