using BusinessLayer.io.employeeManagement.productManagementEmployee;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.ProductManagementEmployeeRepository
{
    public class ProductManagementEmployeeRepository : Repository<ProductManagementEmployee>, IProductManagementEmployeeRepository
    {
        public ProductManagementEmployeeRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public ProductManagementEmployee Get(string id , IEnumerable<Expression<Func<ProductManagementEmployee, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ID == id);
        }
    }
}
