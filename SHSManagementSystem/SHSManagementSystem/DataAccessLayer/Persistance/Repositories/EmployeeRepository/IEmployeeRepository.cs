using BusinessLayer.io.employeeManagement;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee Get(string id , IEnumerable<Expression<Func<Employee, object>>> includes);
    }
}
