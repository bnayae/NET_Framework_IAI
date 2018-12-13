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
#if DEBUG
            Console.WriteLine("Defined");
    #if DB_ACCESSS
            Console.WriteLine("WOW");
    #endif
            Console.WriteLine("hello");
           
#else
            Console.WriteLine("Not-Defined");

#endif
        }
    }
}
