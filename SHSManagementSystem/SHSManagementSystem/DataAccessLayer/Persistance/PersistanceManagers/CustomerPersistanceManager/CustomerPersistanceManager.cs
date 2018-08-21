using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer.contract;
using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.users.address;
using BusinessLayer.io.users.contactInformation;
using DataAccessLayer.Persistance.DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Persistance.PersistanceManagers.CustomerPersistanceManager
{
    public class CustomerPersistanceManager : ICustomerPersistanceManager
    {
        protected readonly IDataHandler dataHandler;

        public CustomerPersistanceManager(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }
        public Customer Get(string id)
        {
            Customer customer = null;
            DataSet ds = dataHandler.Execute(
                "SELECT * FROM Users INNER JOIN Customer ON Users.ID = Customer.ID " +
                "INNER JOIN Address ON User.ID = Address.ID INNER JOIN ContactInformation ON Users.ID" +
                " = ContactInformation.ID WHERE CUSTOMER.ID = '" + id + "'"
                );
            ds.Tables[0].TableName = "UsersInnerJoin";
            foreach (DataRow row in ds.Tables["UsersInnerJoin"].Rows)
            {
                ContactInformation contactInformation = new ContactInformation(row["WorkNumber"].ToString(), row["MobileNumber"].ToString(), row["Email"].ToString());
                Address address = new Address(row["AddressLine1"].ToString(), row["AddressLine2"].ToString(), row["City"].ToString(), row["Country"].ToString(),
                    row["PostalCode"].ToString(), row["Suburb"].ToString());
                // TODO CustomerProductConfiguration customerProductConfiguration = new CustomerProductConfiguration()
                //TODO Billling

                customer = new Customer(row["ID"].ToString(), row["Title"].ToString(), row["Name"].ToString(), row["FullName"].ToString(), row["Surname"].ToString()
                , row["Gender"].ToString(), contactInformation, Convert.ToDateTime(row["DateOfBirth"]), address, new CustomerProductConfiguration(), new BillingInformation(), new Contract());
            }
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            DataSet ds = dataHandler.Execute(
                "SELECT * FROM Users INNER JOIN Customer ON Users.ID = Customer.ID " +
                "INNER JOIN Address ON Users.ID = Address.ID INNER JOIN ContactInformation ON Users.ID" +
                " = ContactInformation.ID"
                );
            ds.Tables[0].TableName = "UsersInnerJoin";
            foreach (DataRow row in ds.Tables["UsersInnerJoin"].Rows)
            {
                // TODO CustomerProductConfiguration customerProductConfiguration = new CustomerProductConfiguration()
                //TODO Billling

                ContactInformation contactInformation = new ContactInformation(row["WorkNumber"].ToString(), row["MobileNumber"].ToString(), row["Email"].ToString());
                Address address = new Address(row["AddressLine1"].ToString(), row["AddressLine2"].ToString(), row["City"].ToString(), row["Country"].ToString(),
                    row["PostalCode"].ToString(), row["Suburb"].ToString());

                customers.Add(new Customer(row["ID"].ToString(), row["Title"].ToString(), row["Name"].ToString(), row["FullName"].ToString(), row["Surname"].ToString()
                , row["Gender"].ToString(), contactInformation, Convert.ToDateTime(row["DateOfBirth"]), address, new CustomerProductConfiguration(), new BillingInformation(), new Contract()));
            }
            return customers;
        }

        public void Add(Customer customer)
        {
            SqlCommand command = new SqlCommand("sp_InsertCustomer");
            command.Parameters.Add(new SqlParameter("@ID", customer.ID));
            command.Parameters.Add(new SqlParameter("@Title", customer.Title));
            command.Parameters.Add(new SqlParameter("@FirstName", customer.Name));
            command.Parameters.Add(new SqlParameter("@Surname", customer.Surname));
            command.Parameters.Add(new SqlParameter("@Gender", customer.Gender));
            command.Parameters.Add(new SqlParameter("@DateOfBirth", customer.DateOfBirth));
            command.Parameters.Add(new SqlParameter("@FullName", customer.FullName));

            command.Parameters.Add(new SqlParameter("@AddressLine1", customer.Address.AddressLine1));
            command.Parameters.Add(new SqlParameter("@AddressLine2", customer.Address.AddressLine2));
            command.Parameters.Add(new SqlParameter("@City", customer.Address.City));
            command.Parameters.Add(new SqlParameter("@Country", customer.Address.Country));
            command.Parameters.Add(new SqlParameter("@PostalCode", customer.Address.PostalCode));
            command.Parameters.Add(new SqlParameter("@Suburb", customer.Address.Suburb));

            command.Parameters.Add(new SqlParameter("@Email", customer.ContactInformation.Email));
            command.Parameters.Add(new SqlParameter("@MobileNumber", customer.ContactInformation.MobileNumber));
            command.Parameters.Add(new SqlParameter("@WorkNumber", customer.ContactInformation.WorkNumber));

            dataHandler.ExecuteStoredProcedure(command);
        }

        public void Remove(Customer customer)
        {
            int result = dataHandler.ExecuteNonQuery(
                "DELETE Customer FROM Customer WHERE Customer.ID = '" + customer.ID + "';" +
                "DELETE Address FROM Address WHERE Address.ID = '" + customer.ID + "';" +
                "DELETE ContactInformation FROM ContactInformation WHERE ContactInformation.ID = '" + customer.ID + "';" +
                "DELETE Users FROM Users WHERE Users.ID = '" + customer.ID + "';"
                );
        }

        public void SaveChanges(Customer customer)
        {
            SqlCommand command = new SqlCommand("sp_UpdateCustomer");
            command.Parameters.Add(new SqlParameter("@ID", customer.ID));
            command.Parameters.Add(new SqlParameter("@FirstName", customer.Name));
            command.Parameters.Add(new SqlParameter("@Title", customer.Title));
            command.Parameters.Add(new SqlParameter("@Surname", customer.Surname));
            command.Parameters.Add(new SqlParameter("@Gender", customer.Gender));
            command.Parameters.Add(new SqlParameter("@DateOfBirth", customer.DateOfBirth));
            command.Parameters.Add(new SqlParameter("@FullName", customer.FullName));

            command.Parameters.Add(new SqlParameter("@AddressLine1", customer.Address.AddressLine1));
            command.Parameters.Add(new SqlParameter("@AddressLine2", customer.Address.AddressLine2));
            command.Parameters.Add(new SqlParameter("@City", customer.Address.City));
            command.Parameters.Add(new SqlParameter("@Country", customer.Address.Country));
            command.Parameters.Add(new SqlParameter("@PostalCode", customer.Address.PostalCode));
            command.Parameters.Add(new SqlParameter("@Suburb", customer.Address.Suburb));

            command.Parameters.Add(new SqlParameter("@Email", customer.ContactInformation.Email));
            command.Parameters.Add(new SqlParameter("@MobileNumber", customer.ContactInformation.MobileNumber));
            command.Parameters.Add(new SqlParameter("@WorkNumber", customer.ContactInformation.WorkNumber));
            dataHandler.ExecuteStoredProcedure(command);
        }
    }
}
