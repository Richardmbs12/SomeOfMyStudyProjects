using BusinessLayer.io.employeeManagement.customerManagementEmployee;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.CustomerManagementEmployeeRepository
{
    public interface ICustomerManagementEmployeeRepository : IRepository<CustomerManagementEmployee>
    {
        CustomerManagementEmployee Get(string id , IEnumerable<Expression<Func<CustomerManagementEmployee, object>>> includes);
    }
}
