using BusinessLayer.io.employeeManagement.productManagementEmployee;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.ProductManagementEmployeeRepository
{
    public interface IProductManagementEmployeeRepository : IRepository<ProductManagementEmployee>
    {
        ProductManagementEmployee Get(string id , IEnumerable<Expression<Func<ProductManagementEmployee, object>>> includes);
    }
}
