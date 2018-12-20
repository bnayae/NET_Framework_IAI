using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f  = new Foo();

            int[] intArrs = f.Concat(1, 2, 3);
            string[] strArray = f.Concat("1", "2", "3");
            var doubleArray = f.Concat(2.3, 4.5, 6.7);


            int[] myIntArrays = f.ToIntArray("1", "2", "3");

            //default C'tor either value type or reference Type
            int[] dummyArr = f.createArray<int>(5);

            List<int> intWithoutDef = f.createWithoutDefaults(1, 2, 3);
            List<int> intWithoutDef2 = f.createWithoutDefaults(1, 2, 0);
            List<string> strWithNoDef = f.createWithoutDefaults(null, "", "hello");
            
            Array.Sort

        }
    }
}
