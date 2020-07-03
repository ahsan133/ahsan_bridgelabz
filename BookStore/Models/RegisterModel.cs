using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RegisterModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
    }
}
