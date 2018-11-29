using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animals
{
    public class Bird : Animal
    {
        private const string VISUAL = @"
     _
----(O)
      \
       \_
       ( `'--.,
        `,___/
          |_\
         /|
         `|
          ^   
";

        public Bird(ConsoleColor c):base(c)
        {
        }
        protected override string Voice => "tweet";
        protected override int Legs => 2;
        protected override string Name => VISUAL;

        protected override int getSpeed()
        {
            return 10;
        }
    }

    public abstract class BlueBird : Animal
    {
        public BlueBird(ConsoleColor c):base(c)
        {

        }

        protected override int getSpeed()
        {
            return -1;
        }

        void myLogic()
        {
            base.Draw();
            ///Do my stuff
        }
    };
}


