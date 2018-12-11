using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Operator_Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo { Value = 3 };
            Foo f1 = f + 2;
            f1 += 10;
            //f1 = f1 + 10;
            Foo f2 = f1 + f;
            Foo f3 = 2 + f;
            f3++;
            //int i = 10;
            //int j = i + 2;
            Foo f4 = 9;
            int j = (int)f4;
            Console.WriteLine(f4 == f3);
        }
    }
}
