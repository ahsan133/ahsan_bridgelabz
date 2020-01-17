using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.EmployeeManager
{
    public class EmployeeManager : IEmployeeManager
    {
        public IEnumerable<Employee> Get()
        {
            IRepository repository = new EmployeeData();
            return repository.GetAllEmployee();
        }


        public void Add(string name, string email, string password, string address)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Email = email;
            employee.Password = password;
            employee.Address = address;

            IRepository repository = new EmployeeData();
            repository.AddEmployee(employee);

        }

        public void Update(string name, string email, string password, string address)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Email = email;
            employee.Password = password;
            employee.Address = address;

            IRepository repository = new EmployeeData();
            repository.UpdateEmployee(employee);
        }

        public void Delete(int id)
        {
            IRepository repository = new EmployeeData();
            repository.DeleteEmployee(id);
        }  
    }
}
