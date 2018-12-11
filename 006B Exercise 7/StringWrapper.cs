using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _005_Exercise_7
{
    [DebuggerDisplay("{Value}")]
    public class StringWrapper
    {
        public StringWrapper(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }

        // ctrl M, O
        // select + ctrl M, M
        #region Operator Overloads

        #region ++

        public static StringWrapper operator ++(StringWrapper a)
        {
            string val = a.Value;
            char add = val[val.Length - 1];
            a.Value = val + add;
            return a;
        }

        #endregion // ++

        #region Casting

        public static implicit operator StringWrapper(string s)
        {
            return new StringWrapper (s);
        }

        public static explicit operator string(StringWrapper f)
        {
            return f.Value;
        }

        #endregion // Csting

        #region +

        public static StringWrapper operator +(StringWrapper a, string b)
        {
            if (string.IsNullOrEmpty(b))
                throw new ArgumentNullException();
            return new StringWrapper (a.Value + b);
        }
        public static StringWrapper operator +(string b, StringWrapper a)
        {
            return new StringWrapper (a.Value + b);
        }
        public static StringWrapper operator +(StringWrapper a, StringWrapper b)
        {
            return new StringWrapper(a.Value + b.Value);
        }

        #endregion // +

        #region Equality

        public static bool operator ==(StringWrapper a, StringWrapper b)
        {
            return a.Value == b.Value;
        }

        public static bool operator !=(StringWrapper a, StringWrapper b)
        {
            return a.Value != b.Value;
        }

        public override bool Equals(object obj)
        {
           StringWrapper b = obj as StringWrapper;
            if (b == null)
                return false;

            return Value == b.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #endregion // Equality

        #endregion // Operator Overloads

        public override string ToString()
        {
            return Value;
        }
    }
}
