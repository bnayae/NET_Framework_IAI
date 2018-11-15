using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _004_Class_Members
{
    public class Foo
    {
        private const string CS = "4546546";
        private static int _counter;
        private readonly static DateTimeOffset _firstUse;
        private int _id;
        private int _i;
        private string _s;

        static Foo()
        {
            Trace.WriteLine("Startic Ctor");
            _firstUse = DateTimeOffset.Now;
        }
        public Foo()
            : this(0, string.Empty)
        {
            //_s = "";
            // _s = string.Empty;
            // _s = "A"; // override the _s data
        }
        public Foo(int i)
            : this(i, string.Empty)
        {
        }
        public Foo(int i, string s)
        {
            //_firstUse = DateTimeOffset.Now;
            _id = _counter++;
            _i = i;
            _s = s;
            string log = Format();
            Trace.WriteLine(log);
            LogFistUse();
        }

        private string Format()
        {
            _id = 10;
            return $"{_s}: {_i}, Id = {_id}";
        }
        private static void LogFistUse()
        {
            Trace.WriteLine(_firstUse);
        }
    }
}
