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

        void Add(string name, string email, string password, string address);

        void Update(string name, string email, string password, string address);

        void Delete(int id);
    }
}
