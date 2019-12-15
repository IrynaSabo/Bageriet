using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class Adress
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostCode { get; set; }
        public string Town { get; set; }
        public string WebAdress { get; set; }

        public Adress(string street, int houseNumber, int postCode, string town, string webAdress)
        {
            Street = street;
            HouseNumber = houseNumber;
            PostCode = postCode;
            Town = town;
            WebAdress = webAdress;
        }
    }
}
