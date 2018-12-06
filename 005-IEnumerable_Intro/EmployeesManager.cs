
using IEnumerable_Intro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class EmployeesManager : IEmployeeManager, IFilter
    {
        private List<Employee> _list = new List<Employee>();

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _list;
        }

        public void AddEmployee(Employee emp)
        {
            _list.Add(emp);
        }

        public void AddAll(IEnumerable<Employee> emps)
        {
            _list.AddRange(emps);
        }

        public void PrintEmployees()
        {
            foreach (Employee item in _list)
            {
                Console.WriteLine(item);

            }
        }

        public IEnumerable<Employee> FilterByGrade()
        {
            List<Employee> results = new List<Employee>();
            foreach (var item in _list)
            {
                if (Filter(item))
                    results.Add(item);
            }
            return results;
        }

        /*public IEnumerable<Employee> FilterByRule(IFilter filterAlgorithm)
        {
            List<Employee> results = new List<Employee>();
            foreach (var item in _list)
            {
                if (filterAlgorithm.Filter(item))
                    results.Add(item);
            }
            return results;
        }*/

        public IEnumerable<Employee> FilterByRule(IFilter filterAlgorithm)
        {
            foreach (var item in _list)
            {
                if (filterAlgorithm.Filter(item))
                    yield return item;
            }
        }





        public void Sort()
        {
            //Array.Sort(_list);
            _list.Sort();
        }

        public bool Filter(Employee e)
        {
            return e.Grade > 80;
        }
    }
}
