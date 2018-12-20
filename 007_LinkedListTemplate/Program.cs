using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_LinkedListTemplate
{
    public interface IPrintable<T>
    {
        void print();
    }

    public class Employee : IPrintable<Employee>
    {
        public void print()
        {
            Console.WriteLine("Employee Printing !!");
        }
    }

    class Cat : IPrintable<Cat>
    {
        public void print()
        {
            Console.WriteLine("Cat  Printing !!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Item<int> last = new Item<int>(3);
             Item<int> v2 = new Item<int>(2, last);
             Item<int> v3 = new Item<int>(1, v2);
             Item<int> header = new Item<int>(0, v3);*/


            /* Item<string> lastStr = new Item<string>("Val3");
             var v2Str = new Item<string>("val2", lastStr);
             var headerStr = new Item<string>("header", v2Str);*/

            Item<List<Employee>> it1 = new Item<List<Employee>>(new List<Employee>());
            Item<Employee> emp1 = new Item<Employee>(new Employee());



            Matrix<Employee> employees = new Matrix<Employee>();
            Matrix<Cat> cats = new Matrix<Cat>();
            employees.Print();
            /*employees.AddItem(new Employee());
            employees.AddItem(new Employee());
            employees.AddItem(new Employee());*/
            EmployyeeMatrix empM = new EmployyeeMatrix();
            empM.AddItem(new Employee());
        }
    }
}
