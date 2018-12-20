using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_GenericMethod
{
    public class Foo
    {
        
        public T[] Concat<T>(T a, T b , T c)
        {
            return new T[] { a, b, c };
        }

        public int[] ToIntArray<T>(T a,T b, T c) where T : IConvertible
        {
            return new int[] { a.ToInt32(null), b.ToInt32(null), c.ToInt32(null) };
        }

        public T[] createArray<T>(int times) where T : new()
        {
            T[] arr = new T[times];
            for (int i = 0; i < times; ++i)
                arr[i] = new T();

            return arr;
        }

        public List<T> createWithoutDefaults<T>(T a , T b  , T c )
        {
            T defaultT = default(T);
            List<T> result = new List<T>();
            if (!object.Equals(a,default(T)))
            {
                result.Add(a);
            }
            if (!object.Equals(default(T),b))
            {
                result.Add(b);
            }
            if (!object.Equals(defaultT, c))
            {
                result.Add(c);
            }

            return result;
        }
    }
}
