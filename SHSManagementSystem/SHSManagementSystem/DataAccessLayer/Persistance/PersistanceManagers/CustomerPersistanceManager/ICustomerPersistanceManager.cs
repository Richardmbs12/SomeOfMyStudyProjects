using BusinessLayer.io.customerManagement.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.PersistanceManagers.CustomerPersistanceManager
{
    public interface ICustomerPersistanceManager
    {
        Customer Get(string id);

        IEnumerable<Customer> GetAll();

        void Add(Customer customer);

        void Remove(Customer customer);

        void SaveChanges(Customer customer);
    }
}
