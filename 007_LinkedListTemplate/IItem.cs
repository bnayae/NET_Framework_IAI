using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_LinkedListTemplate
{
    public interface IItem<T>
    {
        T Data { get; set; }
        IItem<T> Next { get; set; }
    }
}
