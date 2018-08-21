using BusinessLayer.io.customerManagement.customer;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.CustomerRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer Get(string id , IEnumerable<Expression<Func<Customer, object>>> includes);
    }
}
