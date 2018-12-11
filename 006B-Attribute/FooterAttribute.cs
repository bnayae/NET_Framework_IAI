using System;
using System.Collections.Generic;
using System.Text;

namespace _008_Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class FooterAttribute : Attribute
    {
        public FooterAttribute(string text)
        {
            Text = text;
        }
        public string Text { get;  }
    }
}
