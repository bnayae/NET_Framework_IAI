using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_AssemblyIntro
{
    class AdminAttribute : Attribute
    {
        public int times;
        public AdminAttribute(int t)
        {
            times = t;
        }
    }
}
