using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = -5, Y = 5 };
            Point p2 = p1;
            p2.X = -10;


            Console.WriteLine(p1.X);
            validatePoint(p1);
            Console.WriteLine("p1.x = {0}" ,p1.X);

            validatePoint2(ref p1);
            Console.WriteLine("p1.x = {0}", p1.X);

            //The right solutiuon is to return a new point
            //or the same one.
            //dont use ref to Reference
            p1 = validatePoint3(p1);



            //Int.parse demo 
            String s = "12";
            //int v = int.Parse(s);
            int res = 0;
            if(int.TryParse(s, out res))
            {
                Console.WriteLine("Good !"  +res);
            }
        }

        static void validatePoint(Point p)
        {
            if (p.X < 0)
                p = new Point() { X = 0, Y = 0 };
            else
                Console.WriteLine("No Change !");
        }

        static void validatePoint2(ref Point p)
        {
            if (p.X < 0)
                p = new Point() { X = 0, Y = 0 };
            else
                Console.WriteLine("No Change !");
        }

        static Point validatePoint3(Point p)
        {
            if (p.X < 0)
                return new Point() { X = 0, Y = 0 };
            return p;
        }
    }
}
