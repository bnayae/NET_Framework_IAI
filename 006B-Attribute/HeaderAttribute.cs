using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class HeaderAttribute : Attribute
    {
        public HeaderAttribute(string text)
        {
            Text = text;
        }
        public string Text { get;  }
    }
}
