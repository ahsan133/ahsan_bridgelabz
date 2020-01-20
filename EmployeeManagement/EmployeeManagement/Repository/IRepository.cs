using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public interface IRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        void AddEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int? userId);

        bool LoginEmployee(string emal, string password);
    }
}
