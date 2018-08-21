using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.billing.searchCriteria
{
    public class BillingInvoiceSearchCriteria : SearchCriteria
    {
        private string customerId;
        public BillingInvoiceSearchCriteria setCustomerId(string customerId)
        {
            this.customerId = customerId;
            return this;
        }
        public string getCustomerId()
        {
            return this.customerId;
        }
    }
}
