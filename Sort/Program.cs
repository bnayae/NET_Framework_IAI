using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empsArray = new Employee[]
           {
               new Employee() {Id = "9123" },
               new Employee() {Id = "0123" },
               new Employee() {Id = "3123" },
               new Employee() {Id = "6123" },

           };

            List<Employee> empsList = new List<Employee>(empsArray);

            for(int i = 0; i < empsArray.Length; ++ i)
            {
                Console.WriteLine(empsArray[i]);
            }
           
           Array.Sort(empsArray);

        }


        
    }
}
