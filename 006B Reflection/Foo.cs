using System;
using System.Collections.Generic;
using System.Text;

namespace _006_Reflection
{
    public class Foo
    {
        private int _item = 9;
        public int Value { get; set; }
        public int GetData()
        {
            return 42;
        }
        private double GetInfo()
        {
            return 42;
        }
    }
}
