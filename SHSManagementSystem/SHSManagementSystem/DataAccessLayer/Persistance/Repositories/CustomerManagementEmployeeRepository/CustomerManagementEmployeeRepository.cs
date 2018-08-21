using BusinessLayer.io.employeeManagement.customerManagementEmployee;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.CustomerManagementEmployeeRepository
{
    public class CustomerManagementEmployeeRepository : Repository<CustomerManagementEmployee>, ICustomerManagementEmployeeRepository
    {
        public CustomerManagementEmployeeRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public CustomerManagementEmployee Get(string id , IEnumerable<Expression<Func<CustomerManagementEmployee, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ID == id);
        }
    }
}
