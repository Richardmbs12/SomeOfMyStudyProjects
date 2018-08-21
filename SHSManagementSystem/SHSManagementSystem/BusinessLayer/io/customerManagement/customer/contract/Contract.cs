using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.contract
{
    public class Contract
    {

        public Contract()
        {

        }

        public Contract(ContractType contractType, DateTime endDate)
        {
            EndDate = endDate;
            ContractType = contractType;
        }

        public string Type { get; set; }
        public DateTime EndDate { get; set; }
        //EF
        [Key]
        [ForeignKey("Customer")]
        public string ID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("ContractType")]
        public string ContractID { get; set; }
        public virtual ContractType ContractType { get; set; }
    }
}
