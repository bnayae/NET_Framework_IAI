using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntro
{
    class SimpleFilter : IFilterRule
    {
        public bool IsValid(int k)
        {
            return k > 100;
        }
    }
}
