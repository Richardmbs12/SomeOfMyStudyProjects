using BusinessLayer.io.users.loginInformation;
using System;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.address;

namespace BusinessLayer.io.employeeManagement.productManagementEmployee
{
    public class ProductManagementEmployee : Employee
    {
        public ProductManagementEmployee(string id, string titel, string name, string fullName, string surname, string gender,
            ContactInformation contactDetails, DateTime dateOfBirth, LoginInformation loginDetails, Address address) :
            base(id, titel, name, fullName, surname, gender, contactDetails, dateOfBirth, loginDetails, address)
        {
        }

        public ProductManagementEmployee() : base()
        {

        }
    }
}
