using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _007_AssemblyIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create A student
            //Set its name
            //Set its Age
            //Call its print function

        }

        static void Main2(string[] args)
        {
            //1.Get The Assembly !
            //Assembly assembly = Assembly.Load("name-of-assembly");
            foreach(var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                //Console.WriteLine(assembly.GetName());
                //Console.WriteLine("===");
            }

            //Print the Car class
            //1. you start with assembly
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                //2. you look for the Type you are looking for
                foreach (var type in assembly.GetExportedTypes())
                {
                    if(type.Name.Equals("Car"))
                    {
                        //Very Naive , but not always you have the reference itself
                        //Type carType = typeof(Car);
                        //inside the type > do reflection
                        Console.WriteLine("Found the Car Type");
                        DescribeAssembly(type);
                        //Car c = CreateCar(type);
                        CreateAndInit(type);
                        
                    }
                }
            }
            


            Console.ReadLine();

        }

        private static void DescribeAssembly(Type type)
        {
            Console.WriteLine("is public  ?" + type.IsPublic);
            Console.WriteLine("is calss  ?" + type.IsClass);
            //get all Fields 

            foreach(var f in type.GetFields())
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine("Non public");
            foreach (var f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(f.Name);
            }
            
            Console.WriteLine("****");
            foreach (var m in type.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("****");
            var specific_method = type.GetMethod("Drive");
            if (specific_method != null)
            {
                Console.WriteLine("Found drive method");
            }
            Console.WriteLine("****");
            foreach (var m in type.GetMembers())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("****");
        }

        private static Car CreateCar(Type t)
        {
            //in order to produce car you can call the Activator class
            Car c1 = (Car)Activator.CreateInstance(t);
            object c2 = Activator.CreateInstance(t,new object[] { 2016, "Honda" });
            foreach(var cto in t.GetConstructors())
            {
                var parameters = cto.GetParameters();
                
            }
            return c1;
        }

        private static Car CreateAndInit(Type t)
        {
            Car c1 = (Car)Activator.CreateInstance(t);
            FieldInfo fi = t.GetField("_x",BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fi);
            fi.SetValue(c1, 42);

            PropertyInfo modelPropInfo = t.GetProperty("Model");
            modelPropInfo.SetValue(c1, "Hundai");

            //
            Car c2 = new Car(2017, "Subaru");
            string model = (string)modelPropInfo.GetValue(c2);

            return c1;
        }
    }
}
