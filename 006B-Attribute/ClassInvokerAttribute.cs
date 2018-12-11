using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ClassInvokerAttribute: Attribute
    {
        public ConsoleColor Color { get; set; }
    }
}
