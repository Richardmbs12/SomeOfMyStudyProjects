using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.orderManagement.enquiries.customerEnquiry.searchCriteria
{
    public class CustomerEnquirySearchCriteria : SearchCriteria
    {
        private string customerId;
        public CustomerEnquirySearchCriteria setCustomerId(string customerId)
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
