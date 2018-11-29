using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    public class DBA : Programmer
    {
        public DBA(string Id):base(Id)
        {

        }

        public  void Print()
        {
            Console.WriteLine($"DBA: {Id}");
        }
    }
}
