using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int max = lst.Max();

            //Filtering
            IEnumerable<int> filtered = lst.Where(x => x % 2 == 0);
            foreach(var it in filtered)
            {
                Console.WriteLine(it);
            }

            Func<Person, bool> filterFunc = FilterPerson;
            //Transformation
            List<Person> persons = Enumerable.Range(0, 100)
                                  .Select(x => new Person(x))
                                  //.Where(p => (p.Id % 2 == 0))
                                  //.Where(p=>FilterPerson(p))
                                  //.Where(filterFunc)
                                  .Where(FilterPerson)
                                  .ToList();

            //Query Expression
            IEnumerable<Person> person2 = from i in Enumerable.Range(1, 100)
                                          where i % 2 == 0
                                          select new Person(i);

            var orderePerson = person2.OrderBy(p => p.Age).ToArray();
                                          

            //Query Expression
            IEnumerable < string > rs =
                from n in new[] { "Tom", "Dick", "Harry" }
                where n.Contains("a")
                select n;


        }


        public static bool FilterPerson(Person p)
        {
            return p.Id % 2 == 0;
        }
    }
}
