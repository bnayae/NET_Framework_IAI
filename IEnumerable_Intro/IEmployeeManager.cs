using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Intro
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee emp);
        void AddAll(IEnumerable<Employee> emps);
        IEnumerable<Employee> GetAllEmployees();
        void Sort();

        IEnumerable<Employee> FilterByGrade();
        IEnumerable<Employee> FilterByRule(IFilter filterAlgorithm);

    }
}
