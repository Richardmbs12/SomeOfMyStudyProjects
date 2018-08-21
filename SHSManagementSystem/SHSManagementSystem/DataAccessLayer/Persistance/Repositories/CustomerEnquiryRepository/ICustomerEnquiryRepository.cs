using BusinessLayer.io.customerManagement.enquiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.CustomerEnquiryRepository
{
    public interface ICustomerEnquiryRepository : IRepository<CustomerEnquiry>
    {
        CustomerEnquiry Get(int id, IEnumerable<Expression<Func<CustomerEnquiry, object>>> includes);
    }
}
