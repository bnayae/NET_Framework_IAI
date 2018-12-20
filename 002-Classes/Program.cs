using _002_ItemLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            //Cannot do , title is private
            //b.title = "my title";
            Console.WriteLine(b.title); // getter is public


            Point p = new Point();
            int x = p.getX();

            ItemFromHell iFH = new ItemFromHell();
            iFH.print();

            Point p1 = new Point();
            p1 = new Point(4, 5);
            //p = new Point { y = 10, x = 2 }; //if X and Y are public 
            Console.WriteLine(p.getX());

        }
    }
}
