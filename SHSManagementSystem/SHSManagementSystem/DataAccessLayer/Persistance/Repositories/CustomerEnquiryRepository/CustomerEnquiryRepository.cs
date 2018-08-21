using BusinessLayer.io.customerManagement.enquiries;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.CustomerEnquiryRepository
{
    public class CustomerEnquiryRepository : Repository<CustomerEnquiry>, ICustomerEnquiryRepository
    {
        public CustomerEnquiryRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public CustomerEnquiry Get(int id, IEnumerable<Expression<Func<CustomerEnquiry, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.TrackingNumber == id);
        }
    }
}
