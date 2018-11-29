using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog(ConsoleColor.White),
                new Bird(ConsoleColor.Red),
                new Cat(ConsoleColor.Blue),
                new Bird(ConsoleColor.Green)
            };

            foreach(Animal animal in animals)
            {
                animal.Draw();
            }

            foreach (Animal animal in animals)
            {
                animal.Draw(TimeSpan.FromHours(2));
            }

            Console.ReadLine();
        }
    }
}
