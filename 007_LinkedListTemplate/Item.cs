using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_LinkedListTemplate
{
    public class Item<T> : IItem<T> where T : class
    {
        public Item(T data)
        {
            Data = data;
            Next = null;
        }

        public Item(T data,IItem<T> next)
        {
            Data = data;
            Next = next;
        }

        public T Data
        {
            get;set;
        }

        public IItem<T> Next
        {
            get;set;
        }
    }
}
