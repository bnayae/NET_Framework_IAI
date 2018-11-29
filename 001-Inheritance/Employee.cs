using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    public class Employee
    {
        public Employee(string id)
        {
            Id = id;
            Console.WriteLine("Im in Employee c'tor");
        }
        public string Id { get; set; }

        public virtual int CalcSalary()
        {
            //
            return 1000;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Employee: {Id}");
        }
    }
}
