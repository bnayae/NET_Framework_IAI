using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Enumerable_Lazy_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<char> query = GetKeysFull();
            foreach (var item in query)
            {
                Console.Write($"{item}, ");
            }
        }

        private static IEnumerable<char> GetKeys()
        {
            //List<char> items = new List<char>();
            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;
                //items.Add(c);
                yield return c;
            }
            //return items;
        }

        private static IEnumerable<char> GetKeysFull()
        {
            return new CharEnumerable();
        }

        private class CharEnumerable : IEnumerable<char>
        {
            public IEnumerator<char> GetEnumerator()
            {
                return new CharEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private class CharEnumerator : IEnumerator<char>
            {
                private char _c;

                public bool MoveNext()
                {
                    _c = Console.ReadKey(true).KeyChar;
                    return true;
                }

                public char Current => _c;

                object IEnumerator.Current => Current;

                public void Dispose()
                {
                }

                public void Reset()
                {
                }
            }
        }
    }
}
