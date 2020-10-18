using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public bool IsNew => this.ID == default(int);

        public List<Address> Addresses { get; } = new List<Address>();
    }
}
