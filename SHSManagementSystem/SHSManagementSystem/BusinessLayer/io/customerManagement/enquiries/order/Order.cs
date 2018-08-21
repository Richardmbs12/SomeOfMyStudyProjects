using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLayer.io.productManagement.product;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer;

namespace BusinessLayer.io.customerManagement.enquiries.order
{
    [Table("Order")]
    public class Order : CustomerEnquiry
    {
        public Order(int trackingNumber, List<Product> productsOrdered, DateTime enquiryDateTime,
              string enquiryNote, BillingInvoice billingInvoice)
              : base(trackingNumber, enquiryDateTime, enquiryNote)
        {
            ProductsOrdered = productsOrdered;
            BillingInvoice = billingInvoice;
        }

        public Order(List<Product> productsOrdered, DateTime enquiryDateTime,
        string enquiryNote, BillingInvoice billingInvoice)
        : base(enquiryDateTime, enquiryNote)
        {
            ProductsOrdered = productsOrdered;
            BillingInvoice = billingInvoice;
        }
        public Order() : base()
        {

        }

        public virtual List<Product> ProductsOrdered { get; set; }
        public virtual BillingInvoice BillingInvoice { get; set; }
    }
}
