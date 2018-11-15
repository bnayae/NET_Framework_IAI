using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_EqualsOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 3, Y = 5 ,Name = "p1"};
            Point p2 = new Point { X = 3, Y = 5, Name = "p1" };

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1 == p2);
        }
    }
}
