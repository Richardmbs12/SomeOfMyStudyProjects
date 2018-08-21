using BusinessLayer.io.customerManagement.customer.productConfiguration;
using BusinessLayer.io.customerManagement.enquiries.order;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.CustomerProductConfigurationRepository
{
    public class CustomerProductConfigurationRepository : Repository<CustomerProductConfiguration>, ICustomerProductConfigurationRepository
    {
        public CustomerProductConfigurationRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public CustomerProductConfiguration Get(string id, IEnumerable<Expression<Func<CustomerProductConfiguration, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ID == id);
        }
    }
}
