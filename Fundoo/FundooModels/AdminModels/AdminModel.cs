using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModels.AdminModels
{
    public class AdminModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private int id;

        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        [Key]
        public string Email { get => this.email; set => this.email = value; }
        public int Id { get => this.id; set => this.id = value; }
    }
}
