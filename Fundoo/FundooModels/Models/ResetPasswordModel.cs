using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModels.Models
{
    public class ResetPasswordModel
    {
        private string email;
        private string password;
        private string confirmPassword;

        [Key]
        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
        public string ConfirmPassword { get => this.confirmPassword; set => this.confirmPassword = value; }
    }
}
