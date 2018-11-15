using _004_Class_Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_ClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo(1, "A");
            Thread.Sleep(2000);
            Foo f1 = new Foo(2, "B");
            Foo f2 = new Foo();

            Console.ReadKey();
        }
    }
}
