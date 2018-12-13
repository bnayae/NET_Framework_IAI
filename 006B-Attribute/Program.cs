using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _008_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            // FussyInvoke();
            Foo f = new Foo();
            f.Exec();
        }

        private static void FussyInvoke()
        {
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetExportedTypes())
                {
                    ClassInvokerAttribute att = 
                        t.GetCustomAttribute<ClassInvokerAttribute>();
                    if (att == null)
                        continue;

                    ConsoleColor defaultColor = att.Color;

                    object instance = Activator.CreateInstance(t);
                    foreach (MethodInfo m in t.GetMethods())
                    {
                        if (m.ReturnType.Name != "Void")
                            continue;
                        if (m.GetParameters().Length != 0)
                            continue;
                        IEnumerable<InvokerAttribute> matts =
                            m.GetCustomAttributes<InvokerAttribute>();
                       HeaderAttribute head =
                            m.GetCustomAttribute<HeaderAttribute>();
                       FooterAttribute foot =
                            m.GetCustomAttribute<FooterAttribute>();
                        foreach (InvokerAttribute ma in matts)
                        {
                            int times = ma.Times;
                            ConsoleColor c = ma.Color;
                            if (c == ConsoleColor.Black)
                                c = defaultColor;

                            Console.ForegroundColor = c;
                            if(head != null)
                                Console.WriteLine(head.Text);
                            for (int i = 0; i < times; i++)
                            {
                                if (m.IsStatic)
                                    m.Invoke(null, null);
                                else
                                    m.Invoke(instance, null);
                            }
                            if(foot != null)
                                Console.WriteLine(foot.Text);
                            Console.ResetColor();

                        }

                    }
                }
            }
        }
    }
}
