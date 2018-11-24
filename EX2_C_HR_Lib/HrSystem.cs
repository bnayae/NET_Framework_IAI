using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_C_HR_Lib
{
    public class HrSystem
    {
        #region Constants
        private static readonly string WORKER_SEP = ":";
        private static readonly string DIVISION_SEP = "#";
        #endregion

        #region Data Structure
        private string[][] workers;
        #endregion
        
        #region C'tor
        public HrSystem(int divisions)
        {
            workers = new string[divisions][];
        }

        public HrSystem(string allData)
        {
            if(!allData.StartsWith(DIVISION_SEP) || !allData.EndsWith(DIVISION_SEP))
            {
                Console.WriteLine("Incorrect HR System format. exiting");
                workers = new string[0][];
                return;
            }

            string[] divisions = allData.Split(new string[] { DIVISION_SEP }, StringSplitOptions.RemoveEmptyEntries);
            int n = divisions.Length;
            workers = new string[n][];

            for(int i = 0; i < n; ++ i)
            {
                string[] names = divisions[i].Split(new string[] { WORKER_SEP }, StringSplitOptions.RemoveEmptyEntries);
                workers[i] = names;
            }

            Sort();
        }
        #endregion

        /// <summary>
        /// Print the HR System
        /// </summary>
        public void Print()
        {
            int divs = workers.Length;
            for (int i = 0; i < divs; ++i)
            {
                int divSize = workers[i].Length;
                Console.WriteLine($"*****Division {i + 1}******");
                foreach (string workerName in workers[i])
                {
                    Console.WriteLine($"\t{workerName}");
                }
            }

        }

        /// <summary>
        /// Set Division Data Fills a division by names of workers
        /// </summary>
        /// <param name="div">the index of the division</param>
        /// <param name="names">a string representing all the worker names</param>
        public void SetDivisionData(int div, string names)
        {
            string[] workerNames = names.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            int divisionSize = workerNames.Length;
            if (divisionSize == 0)
                workers[div] = new string[0]; //To Prevent Null pointer 
            else
                workers[div] = workerNames;

            //check if this is the last division
            if (div == workers.Length-1)
            {
                Sort();
            }
        }

        /// <summary>
        /// returns all the HR data in a single string
        /// </summary>
        /// <returns>a single string that each division is seperated with # and each worker with :</returns>
        public string AllData()
        {
            StringBuilder sb = new StringBuilder();
            int nDivisions = workers.Length;
            for(int i = 0; i < nDivisions; ++i)
            {
                sb.Append(DIVISION_SEP);
                int divisionSize = workers[i].Length;
                for(int j = 0; j < divisionSize; ++j)
                {
                    sb.Append(workers[i][j]);
                    if(j < divisionSize -1)
                        sb.Append(WORKER_SEP); //put the seperator for all except the last worker
                }
            }
            sb.Append(DIVISION_SEP); // add the last seperator
            return sb.ToString();
        }
        /// <summary>
        /// Sort the workers names in each division
        /// </summary>
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
