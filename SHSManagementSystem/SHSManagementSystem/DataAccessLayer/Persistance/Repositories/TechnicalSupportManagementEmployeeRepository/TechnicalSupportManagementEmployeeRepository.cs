using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.TechnicalManagementEmployeeRepository
{
    public class TechnicalSupportManagementEmployeeRepository : Repository<TechnicalSupportManagementEmployee>, ITechnicalSupportManagementEmployeeRepository
    {
        public TechnicalSupportManagementEmployeeRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public TechnicalSupportManagementEmployee Get(string id , IEnumerable<Expression<Func<TechnicalSupportManagementEmployee, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ID == id);
        }
    }
}
