using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Active_Reflection
{
    public class Bar: IMark
    {
        public void Invoke()
        {
            Console.WriteLine("Invoke");
        }
    }
}
