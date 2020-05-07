using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Login
    {
        private string email;
        private string password;

        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
    }
}
