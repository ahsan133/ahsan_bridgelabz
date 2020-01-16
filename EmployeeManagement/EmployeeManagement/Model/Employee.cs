using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class Employee
    {                                                                                                                                                            
        private int userId;
        private string name;
        private string email;
        private string password;
        private string address;

        public int UserId { get => this.userId; set => this.userId = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
        public string Address { get => this.address; set => this.address = value; }
    }
}
