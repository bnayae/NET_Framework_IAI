using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_RefVrsVal
{
    class Program
    {
        //Demostratiing Reference to parameters
        static void Main(string[] args)
        {
            IntResults ir = new IntResults { x = 3, y = 5 };
            swapWithRef(ir);
            Console.WriteLine(ir.x);

        }
        
        //Demostratiing value by ref/ out parameters
        static void Main3(string[] args)
        {
            string s = "";
            bool isWhite = string.IsNullOrWhiteSpace(s);
            bool result = false;
            MyParser.parseString(null,out result);
            Console.WriteLine(result);
            MyParser.parseString("", out result);
            MyParser.parseString("c", out result);
            MyParser.parseString("      ", out result);
            MyParser.parseString("     hello     ", out result);
            MyParser.parseString("*", out result);
            char cRes = MyParser.parseString("hello world", out result);

            ParseResult pr = MyParser.parseString2(null);
            pr = MyParser.parseString2("         ");
            pr = MyParser.parseString2("      hello   ");
            Console.WriteLine(pr.charRes + " "  + pr.isValid);


        }
        static void Main2(string[] args)
        {
            int i = 3;
            int j = 5;
            swap(i, j);
            Console.WriteLine($"i= {i} , j= {j}");
            swap2(ref i, ref j);
            Console.WriteLine($"i= {i} , j= {j}");

            double d = 100;
            myCalc(d);
            Console.WriteLine(d);

            d = myCalc2(d);
            Console.WriteLine(d);

           
        }


        static void swap(int v,int k)
        {
            int temp = v;
            v = k;
            k = temp;
        }
        
        static void myCalc(double d)
        {
            d *= 100;
        }

        static double myCalc2(double d)
        {
            return (d * 100) + 3;
        }


        static void swap2(ref int v, ref int k)
        {
            int temp = v;
            v = k;
            k = temp;
        }

        //By Reference parameter to function
        static void swapWithRef(IntResults ir)
        {
            int temp = ir.x;
            ir.x = ir.y;
            ir.y = temp;
        }
    }
}
