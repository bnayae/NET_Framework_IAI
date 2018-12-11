using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _011_Exercise_7
{
    public class Exelerator : IExceleration
    {
        private const double Limit = 0.3;
        private const int StartDelaySec = 1;
        public event EventHandler<CrossDirection> CrossLimit;

        public void Print(Func<double, double> strategy)
        {
            double delay = StartDelaySec;
            for (int i = 0; i < 30; i++)
            {
                Console.Write(".");
                TimeSpan duration = TimeSpan.FromSeconds(delay);
                Thread.Sleep(duration);
                delay = strategy(delay);
                double prevDelay = duration.TotalSeconds;

                if (prevDelay >= Limit && delay < Limit)
                {
                    //EventHandler<CrossDirection> crossLimit = CrossLimit;
                    //if (crossLimit != null)
                    //    crossLimit(this, CrossDirection.Up);
                    CrossLimit?.Invoke(this, CrossDirection.Up); // VS 2015
                }
                else if (prevDelay <= Limit && delay > Limit)
                {
                    CrossLimit?.Invoke(this, CrossDirection.Down); // VS 2015
                }
            }
        }
    }
}
