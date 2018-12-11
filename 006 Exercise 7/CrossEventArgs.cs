using System;

namespace _011_Exercise_7
{
    public class CrossEventArgs: EventArgs
    {
        public CrossEventArgs(CrossDirection direction)
        {
            Direction = direction;
        }
        public CrossDirection Direction { get; }
    }
}