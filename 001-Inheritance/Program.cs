using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programmer p = new Programmer("45567");
            Programmer p2 = new Programmer("5432423", 2);
            Console.WriteLine(p2.CalcSalary());

            Employee e1 = new Programmer("54432", 2);
            Console.WriteLine("Salary of Programmer (using Polymorphism" + e1.CalcSalary());

            Console.WriteLine("*********Printing an Employee");
            //e1.Print();
            //p2.Print();

            List<Employee> empList = new List<Employee>();
            empList.Add(p2);
            empList.Add(e1);
            Employee dba = new DBA("777");
            empList.Add(dba);

            foreach (Employee empItem in empList)
            {
                empItem.Print();
            }


            Console.WriteLine("********************");

            Programmer dba2 = new DBA("888");

            dba2.Print();


            
            Console.ReadLine();
        }
    }
}
