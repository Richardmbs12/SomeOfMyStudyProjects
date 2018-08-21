using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.users;
using System;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.loginInformation;
using BusinessLayer.io.users.address;

namespace BusinessLayer.io.employeeManagement.customerManagementEmployee
{
    public class CustomerManagementEmployee : Employee
    {
        public CustomerManagementEmployee(string id, string titel, string name, string fullName, string surname, string gender, ContactInformation contactDetails, DateTime dateOfBirth, LoginInformation loginInformation, Address address) : base(id, titel, name, fullName, surname, gender, contactDetails, dateOfBirth, loginInformation, address)
        {
        }

        public CustomerManagementEmployee() : base()
        {

        }
    }
}
