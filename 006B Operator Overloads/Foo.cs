using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _002_Operator_Overloads
{
    [DebuggerDisplay("{Value}")]
    public class Foo
    {
        public int Value { get; set; }

        // ctrl M, O
        // select + ctrl M, M
        #region Operator Overloads

        #region ++

        public static Foo operator ++ (Foo a)
        {
            a.Value ++;
            return a;
        }

        #endregion // ++

        #region Casting

        public static implicit operator Foo(int i)
        {
            return new Foo { Value = i };
        }

        public static explicit operator int(Foo f)
        {
            return f.Value;
        }

        #endregion // Csting

        #region +

        public static Foo operator + (Foo a, int b)
        {
            //a.Value += b;
            //return a;
            return new Foo { Value = a.Value + b };
        }
        public static Foo operator + (int b, Foo a)
        {
            //a.Value += b;
            //return a;
            return new Foo { Value = a.Value + b };
        }
        public static Foo operator + (Foo a, Foo b)
        {
            //a.Value += b;
            //return a;
            return new Foo { Value = a.Value + b.Value };
        }

        #endregion // +

        #region Equality

        public static bool operator ==(Foo a, Foo b)
        {
            return a.Value == b.Value;
        }

        public static bool operator !=(Foo a, Foo b)
        {
            return a.Value != b.Value;
        }

        public override bool Equals(object obj)
        {
            //if (!(obj is Foo))
            //    return false;
            Foo b = obj as Foo;
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
    }
}
