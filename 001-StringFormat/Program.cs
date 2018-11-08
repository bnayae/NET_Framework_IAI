using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive types :
            int i = 3;
            i++;

            float f = 123.45f;
            double d1 = 12.45999999;

            string str = "hello";
            string myStr;

            myStr = "hello";
            //Immutable String 
            myStr = "world";
            myStr.ToUpper();

            Console.WriteLine("Welocome To My Course " + i);
            Console.WriteLine("MyNum : {0} ,my Double: {1:f2} , myStr: {2}",i,d1,myStr);


            /// Read from input
            Console.WriteLine("Please Enter your name : " );
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to C# {0}",name.ToUpper() );
            string format = $"Welcome to C# {name.ToUpper()} and {4+6}";
            Console.WriteLine($"Welcome to C# {name.ToUpper()} and {{0:f2}}",i*f);
            Console.WriteLine(format);


            //Date Time
            DateTime dt = DateTime.Now;
            double ms = (dt - new DateTime(1970,1, 1)).TotalMilliseconds;
            //double ms = (dt - DateTime.MinValue).TotalMilliseconds;
            double myDouble = 46.1;
            
            Console.WriteLine(dt);
            Console.WriteLine($"day = {dt.Day} / {dt.Month} / {dt.Year} / {dt.Millisecond}");

            Console.WriteLine("{0:o}",dt);


            Console.WriteLine("Please enter your age");
            String ageStr = Console.ReadLine();

            int age = int.Parse(ageStr);

        }
    }
}
