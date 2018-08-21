using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.users.contactInformation
{
    [Table("ContactInformation")]
    public class ContactInformation
    {
        public ContactInformation(string workNumber, string mobileNumber, string email)
        {
            WorkNumber = workNumber;
            MobileNumber = mobileNumber;
            Email = email;
        }

        public ContactInformation()
        {

        }
        public string WorkNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        //EF
        [Key]
        [ForeignKey("User")]
        public string ID { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return WorkNumber +" "+ MobileNumber +" "+ Email;
        }
    }
}
