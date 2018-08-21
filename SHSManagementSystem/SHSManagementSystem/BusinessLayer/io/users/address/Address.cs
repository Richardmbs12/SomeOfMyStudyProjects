using BusinessLayer.io.users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.users.address
{
    [Table("Address")]
    public class Address
    {
        public Address(string addressLine1, string addressLine2, string city, string country, string postalCode, string suburb)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.PostalCode = postalCode;
            this.Suburb = suburb;
            this.Country = country;
        }
        public Address()
        {

        }
        public string Country { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine1 { get; set; }

        //EF
        [Key]
        [ForeignKey("User")]
        public string ID { get; set; }
        public User User { get; set; }

        public override string ToString()
        {
            return AddressLine1 + "\n" + AddressLine2 + "\n" + Suburb + "\n" + PostalCode + "\n" + City + "\n" + Country;
        }
    }
}
