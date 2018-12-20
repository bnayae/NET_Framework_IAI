using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntro
{
    public class Person
    {
        public Person(int id)
        {
            Id = id;
            Name = $"Person_ {Id}";
            BirthDate = DateTime.Today.AddYears(-(Id % 20));
        }

        public override string  ToString()
        {
            return $"Person:{Id}";
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age => (int)(DateTime.Today - BirthDate).TotalDays / 365;
    }
}
