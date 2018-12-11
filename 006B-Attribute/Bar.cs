using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [ClassInvoker]
    public class Bar
    {
        [Invoker(2, Color = ConsoleColor.Blue)]
        public void Invoke()
        {
            Console.WriteLine("Invoke");
        }
    }
}
