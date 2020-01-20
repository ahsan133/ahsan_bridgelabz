using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.EmployeeManager
{
    public class EmployeeManagers : IEmployeeManager
    {
        IRepository repository = new EmployeeData();
        public IEnumerable<Employee> Get()
        {           
            return repository.GetAllEmployee();
        }

        public void Add(Employee employee)
        {
            repository.AddEmployee(employee);
        }

        public void Update(Employee employee)
        {          
            repository.UpdateEmployee(employee);
        }

        public void Delete(int id)
        {
            repository.DeleteEmployee(id);
        }

        public bool Login(string email, string password)
        {
            return repository.LoginEmployee(email, password);
        }
    }
}
