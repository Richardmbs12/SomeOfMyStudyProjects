using BusinessLayer.io.users;
using BusinessLayer.io.users.loginInformation;
using System;
using System.Collections.Generic;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.address;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.io.technicalSupport.schedule;

namespace BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee
{
    [Table("TechnicalSupportEmployee")]
    public class TechnicalSupportManagementEmployee : Employee
    {
        public TechnicalSupportManagementEmployee(string id, string titel, string name, string fullName, string surname, string gender, ContactInformation contactDetails,
            DateTime dateOfBirth, LoginInformation loginDetails, Address address, List<Schedule> schedules) :
            base(id, titel, name, fullName, surname, gender, contactDetails, dateOfBirth, loginDetails, address)
        {
        }

        public TechnicalSupportManagementEmployee() : base()
        {

        }
        //Ef
        public virtual List<Schedule> Schedules { get; set; }
    }
}
