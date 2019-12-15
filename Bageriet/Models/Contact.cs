using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }

        public Contact(string name, string telephone, string email, Adress adress)
        {
            Name = name;
            Adress = adress;
            Telephone = telephone;
            EMail = email;
        }
    }
}
