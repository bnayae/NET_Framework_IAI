using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Tom", "Dick", "Harry", "Mary", "Jay" };

            //IEnumerable<string> query =
            //    from n in names
            //    where n.Contains("a")   // Filter elements
            //    orderby n.Length           // Sort elements
            //    select n.ToUpper();       // Translate each element (project)

            IEnumerable<string> query = names.Where(m => m.Contains("a"))
                                            .OrderBy(m => m.Length)
                                            .Select(m => m.ToUpper());
                                            //.ToArray();

            int count = query.Count();
            string first = names.First();
            Dump(query);
            names.Clear();
            first = names.FirstOrDefault();
            names.Add("Aaa");
            Dump(query);

            Console.ReadKey();
        }

        private static void Dump(IEnumerable<string> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
