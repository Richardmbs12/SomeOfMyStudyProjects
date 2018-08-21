using System;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.address;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.users
{
    public abstract class User
    {
        public User(string id, string titel, string name, string fullName, string surname, string gender, ContactInformation contactInformation, DateTime dateOfBirth,  Address address)
        {
            Title = titel;
            Name = name;
            FullName = fullName;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ID = id;
            Address = address;
            ContactInformation = contactInformation;
        }

        public User(string id, string titel, string name, string fullName, string surname, string gender, DateTime dateOfBirth)
        {
            Name = name;
            FullName = fullName;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ID = id;
            Title = titel;
        }

        public User()
        {

        }

        public string Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        [Key]
        public string ID { get; set; }
        //EF
        public virtual Address Address { get; set; }
        public virtual ContactInformation ContactInformation { get; set; }
    }
}
