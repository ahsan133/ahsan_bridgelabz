using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModels.AdminModels
{
    public class AdminUserList
    {
        private int id;
        private string email;
        private DateTime loginTime;

        public int Id { get => this.id; set => this.id = value; }
        public string Email { get => this.email; set => this.email = value; }
        public DateTime LoginTime { get => this.loginTime; set => this.loginTime = value; }
    }
}
