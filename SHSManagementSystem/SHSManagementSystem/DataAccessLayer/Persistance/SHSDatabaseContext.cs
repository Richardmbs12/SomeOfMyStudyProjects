using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer.contract;
using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.order;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLayer.io.employeeManagement;
using BusinessLayer.io.employeeManagement.customerManagementEmployee;
using BusinessLayer.io.employeeManagement.productManagementEmployee;
using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using BusinessLayer.io.productManagement.product;
using BusinessLayer.io.productManagement.productType;
using BusinessLayer.io.technicalSupport.schedule;
using BusinessLayer.io.technicalSupport.technicalTask;
using BusinessLayer.io.users;
using BusinessLayer.io.users.address;
using BusinessLayer.io.users.contactInformation;
using BusinessLayer.io.users.loginInformation;
using DataAccessLayer.Persistance.EntityConfigurations;
using System.Data.Entity;

namespace DataAccessLayer.io
{
    public class SHSDatabaseContext : DbContext
    {
        public SHSDatabaseContext():base("SHSManagementDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<CustomerManagementEmployee> CustomerManagementEmployee { get; set; }
        public virtual DbSet<TechnicalSupportManagementEmployee> TechnicalSupportEmployee { get; set; }
        public virtual DbSet<ProductManagementEmployee> ProductManagementEmployee { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<LoginInformation> LoginInformation { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<TechnicalTask> TechnicalTask { get; set; }
        //public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<CustomerEnquiry> CustomerEnquiry { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<TechnicalSupportEnquiry> TechnicalSupportEnquiry { get; set; }
        public virtual DbSet<BillingInformation> BillingInformation { get; set; }
        public virtual DbSet<BillingInvoice> BillingInvoice { get; set; }
        public virtual DbSet<CustomerProductConfiguration> CustomerProductConfiguration { get; set; }
        public virtual DbSet<ProductInstallationHistory> ProductInstallationHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
