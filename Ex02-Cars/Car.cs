using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Cars
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }

        #region properties
        private string color = CarDefs.DEFAULT_COLOR;
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color
        {
            get { return color; }
            set
            {
                if (CarDefs.Colors.Contains(value))
                    color = value;
            }
        }
        #endregion

        #region Equals
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            Car other = (Car)obj;

            return Model.Equals(other.Model)
                    && Year == other.Year
                    && color.Equals(other.color);
                            
        }
        #endregion


    }
}
