using BusinessLayer.io.customerManagement.enquiries.order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.billing
{
    public class BillingInvoice
    {
        public BillingInvoice()
        {

        }

        public BillingInvoice(double totalPrice, double amountDue, double creditAmount, DateTime date)
        {
            AmountDue = amountDue;
            CreditAmount = creditAmount;
            Date = date;
            TotalPrice = totalPrice;
        }

        public double TotalPrice { get; set; }
        public double AmountDue { get; set; }
        public double CreditAmount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime Date { get; set; }
        //EF
        public virtual BillingInformation BillingInformation { get; set; }
        [Key]
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
