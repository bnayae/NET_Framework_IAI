using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary 
            Dictionary<Point, string> dictionary = new Dictionary<Point, string>();

            Point p1 = new Point(1, 2);
            Point p2 = new Point(2, 3);
            Point p3 = new Point(1, 2);

            dictionary.Add(p1, "tomer");
            dictionary.Add(p2, "ronen");
            //dictionary.Add(p3, "avi");

            Console.WriteLine("number of items =  " + dictionary.Count);



            Point p5 = new Point(1, 2);

            /*if(p5.Equals(p3))
                Console.WriteLine("I told you !");*/

            if(dictionary.ContainsKey(p5))
                Console.WriteLine("YES !!!");

        }
    }
}
