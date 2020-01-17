using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.EmployeeManager
{
    public interface IEmployeeManager
    {
        IEnumerable<Employee> Get();

        void Add(Employee employee);

        void Update(Employee employee);

        void Delete(int id);
    }
}
