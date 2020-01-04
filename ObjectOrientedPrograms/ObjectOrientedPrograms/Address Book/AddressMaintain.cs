using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Address_Book
{
    public class AddressMaintain
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private int zip;
        private long phone;


        public string FirstName { get => this.firstname; set => this.firstname = value; }
        public string LastName { get => this.lastname; set => this.lastname = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public int Zip { get => this.zip; set => this.zip = value; }
        public long Phone { get => this.phone; set => this.phone = value; }
    }
}
