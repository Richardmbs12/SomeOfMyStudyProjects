using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.address;
using BusinessLayer.io.customerManagement.customer.contract;

namespace BusinessLayer.io.customerManagement.customer
{
    [Table("Customer")]
    public class Customer : User
    {
        private List<CustomerEnquiry> customerEnquiries;
        public Customer(string id, string titel, string name, string fullName, string surname, string gender, DateTime dateOfBirth) : base(id, titel, name, fullName, surname, gender, dateOfBirth)
        {
        }

        public Customer(string id, string titel, string name, string fullName, string surname, string gender, ContactInformation contactInformation,
        DateTime dateOfBirth, Address address)
        : base(id, titel, name, fullName, surname, gender, contactInformation, dateOfBirth, address)
        {
        }

        public Customer(string id, string title, string name, string fullName, string surname, string gender, ContactInformation contactInformation,
            DateTime dateOfBirth, Address address, CustomerProductConfiguration productConfiguration,
            BillingInformation billingInformation, Contract contract)
            : base(id, title, name, fullName, surname, gender, contactInformation, dateOfBirth, address)
        {
            this.ProductConfiguration = productConfiguration;
            this.BillingInformation = billingInformation;
            this.Contract = contract;
        }

        public Customer()
        {

        }


        //EF
        public virtual BillingInformation BillingInformation { get; set; }
        public virtual CustomerProductConfiguration ProductConfiguration { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual List<CustomerEnquiry> CustomerEnquiries
        {
            get
            {
                if (customerEnquiries == null)
                {
                    customerEnquiries = new List<CustomerEnquiry>();
                }
                return customerEnquiries;
            }
            set {customerEnquiries = value;}
        }

    }
}
