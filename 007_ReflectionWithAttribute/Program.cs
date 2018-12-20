using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _007_ReflectionWithAttribute
{
    class Program
    {
        static void Main(string[] args)
        { 
            Assembly assembly = Assembly.Load("07_DataModel");
            Type printerAttribute = null;
            Type studentType = null;
            //1. Get the class of the PrinterAttribute
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(Attribute)))
                {
                    if (type.Name.Contains("Printer"))
                    {
                        printerAttribute = type;
                    }
                }
                if (type.Name.Equals("Student"))
                {
                    studentType = type;
                }
            }
            if (printerAttribute == null || studentType == null)
            {
                Console.WriteLine(":-(");
                return;
            }

            //extract the print method
            foreach (var mi in studentType.GetMethods())
            {
                Attribute pr = mi.GetCustomAttribute(printerAttribute);
                if (pr != null)
                {
                    Console.WriteLine("WOW");
                    object student = Activator.CreateInstance(studentType);
                    mi.Invoke(student, null);
                }
            }
        }
    }
}
