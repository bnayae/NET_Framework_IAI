using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [ClassInvoker(Color = ConsoleColor.Green)]
    public class Foo
    {
        [Header("@@@@@@@@@@@@@@@@@")]
        [Footer("!!!!!!!!!!!!!!!!")]
        [Invoker(2, Color = ConsoleColor.White)]
        [Invoker(3)]
        public void Exec()
        {
            Console.WriteLine("Exec");
        }
        [Header("=====================")]
        [Footer("/////////////////////")]
        [Invoker(4, Color = ConsoleColor.Yellow)]
        public static void Run()
        {
            Console.WriteLine("Run");
        }
        public void Operate()
        {
            Console.WriteLine("Operate");
        }
    }
}
