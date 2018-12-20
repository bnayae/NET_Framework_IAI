using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Serializable]
    public class Student
    {
        public Student()
        {
           Age = 42;
        }
        
        public string Name { get; set; }
        public int Age { get; private set; }
        
        [Printer(3)]
        [AccessAuthentication("Admin")]
        public void PrintYYYYY34()
        {
          Console.WriteLine($"Student : {Name}  , {Age}");
        }
               
    }

    
}
