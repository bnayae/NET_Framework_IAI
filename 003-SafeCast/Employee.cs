using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_SafeCast
{
    public class Employee
    {
        public int Id { get; set; }


    }

    public class Programmer : Employee
    {
        public void Code()
        {
            Console.WriteLine("Im coding");
        }
    }
}
