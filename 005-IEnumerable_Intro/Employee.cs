using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Employee : IComparable, IComparable<Employee>
    {
        public string Id { get; set; } // e.g "029554268"
        public int Grade { get; set; }

        public Employee(string id, int grade)
        {
            Id = id;
            Grade = grade;
        }
        public int CompareTo(Employee other)
        {
            return Id.CompareTo(other.Id);
        }

        //int grade;

        public int CompareTo(object obj)
        {
            return CompareTo((Employee)obj);
        }

        public override string ToString()
        {
            return $"Id = {Id}";
        }
    }
}
