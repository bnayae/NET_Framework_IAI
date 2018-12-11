//#define QA

using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Pre_Processing_Directives
{
    class Program
    {
        static void Main(string[] args)
        {
#if QA
            Console.WriteLine("Defined");
#else
            Console.WriteLine("Not-Defined");
#endif
        }
    }
}
