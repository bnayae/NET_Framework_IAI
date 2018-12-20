using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_LinkedListTemplate
{
    public class Matrix<T>  where T :class, IPrintable<T>,new()
    {
        private T[] items;
        private int size = 0;
        public Matrix()
        {
            items = new T[100];//[null,null,null]
            for(int i=0; i < 100; ++i)
            {
                items[i] = new T();
            }

        }

        public void AddItem(T it)
        {
            if(size < 100)
                items[size++] = it;
        }

        public void Print()
        {
            for (int i = 0; i < size; ++i)
                items[i].print();
        }
    }


    public class EmployyeeMatrix : Matrix<Employee>
    {

    }
}
