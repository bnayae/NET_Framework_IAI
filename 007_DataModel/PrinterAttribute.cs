using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class PrinterAttribute : Attribute
    {
        public PrinterAttribute(int times)
        {
            Times = times;
        }

        public int Times { get; set; }
    }

    public class AccessAuthenticationAttribute : Attribute
    {
        public AccessAuthenticationAttribute(string allowed)
        {
            Role = allowed;
        }

        public string Role { get; set; }
    }
}
