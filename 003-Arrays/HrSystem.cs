using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arrays
{
    public class HrSystem
    {
        string[][] workers;

        public HrSystem(int divisions)
        {
            workers = new string[divisions][];
        }

        public void InitHR()
        {
            for(int i= 0; i < workers.Length; ++ i)
            {
                Console.WriteLine($"Please enter the number of people in Division {i+1}");
                int n = int.Parse(Console.ReadLine());
                inputDivisionData(i, n);
            }

            Sort();
        }

        public void Print()
        {
            int divs = workers.Length;
            for (int i = 0; i < divs; ++i)
            {
                int divSize = workers[i].Length;
                Console.WriteLine($"*****Division {i + 1}******");
                //Option A :
                /*for (int j = 0; j < divSize; ++j)
                {
                    Console.WriteLine($"\t{workers[i][j]}");
                }*/
                //Option B using foreach
                foreach(string workerName in workers[i])
                {
                    Console.WriteLine($"\t{workerName}");
                }
            }
            
        }
        
       

        private void inputDivisionData(int div,int size)
        {
            workers[div] = new string[size];
            for(int i = 0; i < size; ++i)
            {
                Console.WriteLine($"Please enter name of worker {i+1}: ");
                string workerName = Console.ReadLine();
                workers[div][i] = workerName;
            }

        }

        private void Sort()
        {
            int divs = workers.Length;
            for (int i = 0; i < divs; ++i)
            {
                Array.Sort(workers[i]);
            }
        }


    }
}
