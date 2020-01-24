using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModels.Models
{
    public class ForgotPasswordModel
    {
        private string email;

        [Key]
        public string Email { get => this.email; set => this.email = value; }
    }
}
