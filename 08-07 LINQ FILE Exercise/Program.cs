using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_07_LINQ_FILE_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("AnimalFarm.txt");
            var exclude = lines.Where(l => l.IndexOf("Napoleon", StringComparison.OrdinalIgnoreCase) != -1 &&
                                            !string.IsNullOrEmpty(l));
            var tzenzor = exclude.Select(l => l.Replace("animals", "IAI"));

            using (var srm = File.OpenWrite("data.compressed"))
            using (var zip = new GZipStream(srm, CompressionMode.Compress))
            using (var w = new StreamWriter(zip))
            //using (var w = File.CreateText("data.compressed"))
            {
                foreach (var line in tzenzor)
                {
                    w.WriteLine(line);
                    Console.Write(".");
                }
            }

            Console.WriteLine();

            using (var srm = File.OpenRead("data.compressed"))
            using (var zip = new GZipStream(srm, CompressionMode.Decompress))
            using (var r = new StreamReader(zip))
            //using (var r = File.ReadLines("data.compressed"))
            {
                while (!r.EndOfStream)
                {
                    for (int i = 0; i < 10 && !r.EndOfStream; i++)
                    {
                        string line = r.ReadLine();
                        Console.WriteLine(line);
                    }
                    Console.ReadKey(true);
                }
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
