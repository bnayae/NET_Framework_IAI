using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class InvokerAttribute: Attribute
    {
        public InvokerAttribute(byte times)
        {
            Times = times;
        }
        public byte Times { get;  }
        public ConsoleColor Color { get; set; } = ConsoleColor.Black;
    }
}
