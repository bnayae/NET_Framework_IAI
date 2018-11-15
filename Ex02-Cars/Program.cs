using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Golf", 2018, "yellow");// actually its Gray sicne there is no such color "yellow"
            Car c2 = new Car("Golf", 2018, "Gray");

            if (c.Equals(c2))
            {
                Console.WriteLine("Cars are the same");
            }

            //BONUS : Put cars in array
            Car[] garage = new Car[] {
                new Car("Hundai", 2016, "Blue"),
                new Car("Kaya", 2012, "Blue"),
                new Car("Honda", 2015, "Red"),
                new Car("Golf", 2016, "Gray")
            };

            Console.WriteLine("finding Gray golf with new Car(Golf, 2018, 'yellow')");
            if (garage.Contains(new Car("Golf", 2016, "yello")))
            {
                Console.WriteLine("Yes ! we found the car.");
            }

            if(!garage.Contains(new Car("Kaya",2013,"Blue")))
            {
                Console.WriteLine("Kaya from 2013 cannot be found ");
            }

            //trying to change color 3 more  times :
            c2.Color = "Red"; // OK
            c2.Color = "Blue"; // LAST TIME
            c2.Color = "Gray"; //will not work
            Console.WriteLine(c2.Color); //Blue !!
        }
    }
}
