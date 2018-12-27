using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_Yield
{
    class Foo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new E();

            //for (int i = 0; i < 10; i++)
            //{
            //    yield return i;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class E : IEnumerator<int>
        {
            private int _i = -1;

            public bool MoveNext()
            {
                _i++;
                return _i < 10;
            }

            public int Current => _i;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public void Reset()
            {
                _i = -1;
            }
        }
    }
}
