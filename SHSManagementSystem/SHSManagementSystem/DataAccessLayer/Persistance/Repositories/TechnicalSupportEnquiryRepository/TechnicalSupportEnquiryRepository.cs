using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.TechnicalSupportEnquiryRepository
{
    public class TechnicalSupportEnquiryRepository : Repository<TechnicalSupportEnquiry>, ITechnicalSupportEnquiryRepository
    {
        public TechnicalSupportEnquiryRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public TechnicalSupportEnquiry Get(int id, IEnumerable<Expression<Func<TechnicalSupportEnquiry, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.TrackingNumber == id);
        }
    }
}
