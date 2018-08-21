using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.technicalSupport.technicalTask;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.customerManagement.enquiries
{
    [Table("CustomerEnquiry")]
    public class CustomerEnquiry
    {
        public CustomerEnquiry(int trackingNumber, DateTime enquiryDateTime, string enquiryNote)
        {
            this.TrackingNumber = trackingNumber;
            this.EnquiryDateTime = enquiryDateTime;
            this.EnquiryNote = enquiryNote;
        }

        public CustomerEnquiry(DateTime enquiryDateTime, string enquiryNote)
        {
            this.EnquiryDateTime = enquiryDateTime;
            this.EnquiryNote = enquiryNote;
        }
        public CustomerEnquiry()
        {
                
        }
        public string EnquiryNote { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime EnquiryDateTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TrackingNumber { get; set; }
        public virtual TechnicalTask TechnicalTask { get; set; }
        //EF
        public virtual Customer Customer { get; set; }

        public override string ToString()
        {
            return TrackingNumber.ToString();
        }
    }
}
