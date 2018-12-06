using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(1, 2, 3);

            if (p.Equals(p2))
                 Console.WriteLine("yes");

            object other = p2;

            if(p.Equals(other))
                Console.WriteLine("yes");
            //TODO : explain this : why is it true ? Hunch : value comparison
            if(object.Equals((object)other, p))
                Console.WriteLine("???");
            if(ReferenceEquals(other,p))
                Console.WriteLine("???"); 


        }
    }
}

