using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _011_Exercise_7
{
    public interface IExceleration
    {
        //event Action<CrossDirection> CrossLimit;
        //event EventHandler<CrossEventArgs> CrossLimit;
        event EventHandler<CrossDirection> CrossLimit;

        void Print(Func<double, double> strategy);
    }
}
