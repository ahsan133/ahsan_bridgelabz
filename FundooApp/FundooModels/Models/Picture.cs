using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModels.Models
{
    public class Picture
    {
        private string email;
        private IFormFile image;

        public string Email { get => this.email; set => this.email = value; }
        public IFormFile Image { get => this.image; set => this.image = value; }
    }
}
