using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ConfigInterfaceDemo
{
    class Program
    {
        static bool isDebug = false;
        static void Main(string[] args)
        {
            IConfig config = null;

            if (isDebug)
            {
                config = new XmlConfig();
            }
            else
            {
                config = new DbConfig();
            }

            printValueFromConfig(config);
        }

        private static void printValueFromConfig(IConfig config)
        {
            Console.WriteLine(config.readProperty("username"));
        }
    }
}
