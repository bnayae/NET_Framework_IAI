using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03_Word_Count
{
    class Program
    {
        private static readonly char[] _splittingChars = { ' ', '-', '.', '\t', ';', ':', ',', '{', '}', ')', '(', '[', ']' };
        private static readonly HashSet<string> _ignoreWords =
            new HashSet<string>
                { "the", "and", "she", "you", "have", "has", "does", "are", "for", "this",
                "was", "were", "on", "in", "had", "that", "they" ,"his","with","their"
                ,"not","been","them", "all","which","from","out","there","but", "him"
                , "other", "did", "into", "than", "every", "any", "what", "her", "never", "after"
                , "very", "about", "even" , "our", "no", "of", "is", "we", "do", "to", "it", "he"};

        static void Main(string[] args)
        {

            IEnumerable<string> lines = File.ReadLines("AnimalFarm.txt");
            IEnumerable<string> words = lines.SelectMany(line => line.Split(_splittingChars, StringSplitOptions.RemoveEmptyEntries));
            IEnumerable<string> filtered = words.Where(w => !_ignoreWords.Contains(w) && w.Length > 1);
            var groups = filtered.GroupBy(m => m);
            var groupAndCount = groups.Select(m => new { Word = m.Key, Count = m.Count() });
            var ordered = groupAndCount.OrderByDescending(m => m.Count);
            foreach (var item in ordered.Take(10))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


        // Group by
        //string[] arr = { "asbs", "ahhd", "shhh", "yhhh", "sjj" };
        ////var gs = arr.GroupBy(m => m[0], m => $"## {m} ##");
        //var gs = from item in arr
        //         group item by item[0];
        //foreach (var g in gs)
        //{
        //    Console.WriteLine(g.Key);
        //    foreach (var item in g)
        //    {
        //        Console.WriteLine($"\t{item}");
        //    }
        //}
    }
}
