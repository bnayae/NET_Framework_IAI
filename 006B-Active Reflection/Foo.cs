using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Active_Reflection
{
    public class Foo: IMark, IExecuter
    {
        public void Exec()
        {
            Console.WriteLine("Exec");
        }
        public static void Run()
        {
            Console.WriteLine("Run");
        }
        public void Operate(int i)
        {
            Console.WriteLine("Operate");
        }
    }
}
