using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Exercise_5
{
    public class Foo: IEnumerable<string>
    {
        private int[] _index = { 2, 4, 6, 8 };
        private string[] _data = { "A", "B", "C", "D" };

        public string this[int i]
        {
            get
            {
                int index = Array.IndexOf(_index, i);
                return _data[index];
            }
            set
            {
                 int index = Array.IndexOf(_index, i);
                _data[index] = value;
            }
        }

        public IEnumerable<int> GetIndexs()
        {
            foreach (int item in _index)
            {
                yield return item;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string item in _data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
