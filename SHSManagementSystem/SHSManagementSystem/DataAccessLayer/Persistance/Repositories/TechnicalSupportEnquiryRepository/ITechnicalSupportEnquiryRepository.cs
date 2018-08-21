using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.TechnicalSupportEnquiryRepository
{
    public interface ITechnicalSupportEnquiryRepository : IRepository<TechnicalSupportEnquiry>
    {
        TechnicalSupportEnquiry Get(int id, IEnumerable<Expression<Func<TechnicalSupportEnquiry, object>>> includes);
    }
}
