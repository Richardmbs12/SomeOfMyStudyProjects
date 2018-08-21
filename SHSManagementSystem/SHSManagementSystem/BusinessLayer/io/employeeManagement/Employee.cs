using BusinessLayer.io.users.loginInformation;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.address;
using BusinessLayer.io.users;

namespace BusinessLayer.io.employeeManagement
{
    [Table("Employee")]
    public class Employee : User
    {
        public Employee(string id, string titel, string name, string fullName, string surname, string gender, ContactInformation contactInformation, DateTime dateOfBirth, LoginInformation loginInformation, Address address) : base(id, titel, name, fullName, surname, gender, contactInformation, dateOfBirth, address)
        {
            LoginDetails = loginInformation;
        }

        public Employee() : base()
        {

        }

        public virtual LoginInformation LoginDetails { get; set; }
    }
}
