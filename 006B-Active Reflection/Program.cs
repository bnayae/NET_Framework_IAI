using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _007_Active_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //FussyInvoke();
            InterfaceInvoke();

            Console.ReadKey();
        }

        private static void InterfaceInvoke()
        {
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetExportedTypes())
                {
                    Type i = t.GetInterface(typeof(IExecuter).FullName);
                    if (i == null)
                        continue;

                    IExecuter instance = (IExecuter)Activator.CreateInstance(t);
                    instance.Exec();
                }
            }
        }

        private static void FussyInvoke()
        {
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetExportedTypes())
                {
                    Type i = t.GetInterface(typeof(IMark).FullName);
                    if (i == null)
                        continue;

                    object instance = Activator.CreateInstance(t);
                    foreach (MethodInfo m in t.GetMethods())
                    {
                        if (m.ReturnType.Name != "Void")
                            continue;
                        if (m.GetParameters().Length != 0)
                            continue;

                        if (m.IsStatic)
                            m.Invoke(null, null);
                        else
                            m.Invoke(instance, null);
                    }
                }
            }
        }
    }
}
