using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.TechnicalManagementEmployeeRepository
{
    public interface ITechnicalSupportManagementEmployeeRepository : IRepository<TechnicalSupportManagementEmployee>
    {
        TechnicalSupportManagementEmployee Get(string id , IEnumerable<Expression<Func<TechnicalSupportManagementEmployee, object>>> includes);
    }
}
