using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Intro
{
    public interface IFilter
    {
        bool Filter(Employee e);
    }
}
