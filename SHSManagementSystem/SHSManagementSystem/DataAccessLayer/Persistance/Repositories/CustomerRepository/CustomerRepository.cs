using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.users.address;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.CustomerRepository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public Customer Get(string id , IEnumerable<Expression<Func<Customer, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ID == id);
        }
    }
}
