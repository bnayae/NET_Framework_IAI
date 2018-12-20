using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_AssemblyIntro
{
    public class Car
    {
        public Car()
        {

        }
        public Car(int year, string model)
        {
            this.year = year;
            this.Model = model;
        }
        
        public int year; ///field
        public string Model { get; set; } //property

        [AdminAttribute(4)]
        public void Drive(int km) // method
        {
            Console.WriteLine($"Driving {km} km" );
        }


        private int _x;
    }
}
