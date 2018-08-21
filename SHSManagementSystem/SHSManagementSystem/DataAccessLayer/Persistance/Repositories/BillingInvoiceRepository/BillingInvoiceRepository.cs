using BusinessLayer.io.customerManagement.customer.billing;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.BillingInvoiceRepository
{
    public class BillingInvoiceRepository : Repository<BillingInvoice>, IBillingInvoiceRepository
    {
        public BillingInvoiceRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }
    }
}
