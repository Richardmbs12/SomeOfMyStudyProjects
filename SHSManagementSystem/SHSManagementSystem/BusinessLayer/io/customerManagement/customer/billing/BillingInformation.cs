using BusinessLayer.io.customerManagement.enquiries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.billing
{
    [Table("BillingInformation")]
    public class BillingInformation
    {
        private List<BillingInvoice> billingHistory;

        public BillingInformation(string accountNumber, string bank, string branch, List<BillingInvoice> billingHistory)
        {
            this.AccountNumber = accountNumber;
            this.Bank = bank;
            this.Branch = branch;
            this.BillingHistory = billingHistory;
        }

        public BillingInformation()
        {

        }
        public string Branch { get; set; }
        public string Bank { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        //EF

        public List<BillingInvoice> BillingHistory { get; set; }
        [Key]
        [ForeignKey("Customer")]
        public string ID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
