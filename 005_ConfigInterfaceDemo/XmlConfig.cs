using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ConfigInterfaceDemo
{
    public class XmlConfig : IConfig
    {
        public string readProperty(string propName)
        {
            Console.WriteLine("Reading property from XML");
            return "<" + propName + "</>";
        }
    }
}
