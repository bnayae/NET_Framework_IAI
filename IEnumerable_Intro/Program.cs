using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeManager empManager = new EmployeesManager();
            empManager.AddEmployee(new Employee("6123",78));
            empManager.AddEmployee(new Employee("4123", 87));
            empManager.AddEmployee(new Employee("512301", 67));
            empManager.AddEmployee(new Employee("712301", 63));
            empManager.AddEmployee(new Employee("012301", 61));



            Employee[] empsArray = new Employee[]
          {
               new Employee("9123", 97),
               new Employee("7423", 67),
               new Employee("3423", 84)
          };
            
            //empManager.AddAll(empsArray);
            empManager.Sort();
            IEnumerable<Employee> lst = empManager.GetAllEmployees();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }


            ///FILTER EXAMPLE
            IEnumerable<Employee> excellents = empManager.FilterByGrade();
            IEnumerable<Employee> excellents2 = empManager.FilterByRule(new MyOtherFilter(60));
            empManager.AddAll(empsArray);
            foreach (Employee em in excellents2)
            {
                Console.WriteLine(em);
            }
            IEnumerable<Employee> excellents3 = empManager.FilterByRule(new MyOtherFilter(70));

        }

        
    }

    public class MyOtherFilter : IFilter
    {
        int minValue;
        public MyOtherFilter(int val)
        {
            minValue = val;
        }
        public bool Filter(Employee e)
        {
            return e.Grade > minValue && e.Id.Length > 5;
        }
    }
}
