using System;
using BusinessLayer.io.customerManagement.customer;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry
{
    [Table("TechnicalSupportEnquiry")]
    public class TechnicalSupportEnquiry : CustomerEnquiry
    {
        public TechnicalSupportEnquiry(int trackingNumber, DateTime enquiryDateTime, string enquiryNote)
            : base(trackingNumber, enquiryDateTime, enquiryNote)
        {
        }

        public TechnicalSupportEnquiry()
        {

        }
    }
}
