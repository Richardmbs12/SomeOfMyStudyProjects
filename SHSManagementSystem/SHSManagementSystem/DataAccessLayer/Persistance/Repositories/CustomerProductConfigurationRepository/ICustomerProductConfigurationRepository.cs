using BusinessLayer.io.customerManagement.customer.productConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.CustomerProductConfigurationRepository
{
    public interface ICustomerProductConfigurationRepository : IRepository<CustomerProductConfiguration>
    {
        CustomerProductConfiguration Get(string id, IEnumerable<Expression<Func<CustomerProductConfiguration, object>>> includes);
    }
}
