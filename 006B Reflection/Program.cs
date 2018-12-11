using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace _006_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly.LoadFile(@"C:\Users\mht-stud0\Desktop\C#\IAI 2017\005 Exercise 7\bin\Debug\005 Exercise 7.exe");
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                Console.WriteLine(a.GetName().Name);
                //foreach (Type t in a.GetExportedTypes())
                //{
                //    Console.WriteLine($"\t{t.Name}");
                //}
            }
            Console.WriteLine();
            //Reflect(typeof(int));
            Reflect(typeof(Foo));
        }

        private static void Reflect(Type t)
        {
            Console.WriteLine($"Assembly = {t.Assembly.GetName().Name}");
            Console.WriteLine($"Type = {t.Name}, is abstract = {t.IsAbstract}");
            Console.WriteLine("METHODS:");
            foreach (MethodInfo m in t.GetMethods(
                BindingFlags.Static | BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine();
                Console.Write(m.ReturnParameter.ParameterType.Name);
                Console.Write($" {m.Name} (");
                foreach (ParameterInfo p in m.GetParameters())
                {
                    Console.Write($" {p.ParameterType.Name} {p.Name}, ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("PROPERTIES:");
            foreach (PropertyInfo p in t.GetProperties(
                BindingFlags.Static | BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine();
                Console.Write($"{p.PropertyType.Name} {p.Name} (");
            }
        }
    }
}
