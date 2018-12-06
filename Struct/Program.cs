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
            
            //Explanation : 
            //https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals?view=netframework-4.7.2
            //1. if the value type / struct has fields that are all value- > Bit Comparison
            //2. if there are Reference type , there is a reflection (performance)
            //3. always override Equals for Value type if you have Reffernce inside them
            if (Equals(other, p))
                Console.WriteLine("???");

            if (ReferenceEquals(other,p))
                Console.WriteLine("???"); 


        }
    }
}

