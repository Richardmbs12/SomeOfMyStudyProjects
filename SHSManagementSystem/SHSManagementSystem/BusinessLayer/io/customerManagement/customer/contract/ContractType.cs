using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.contract
{
    public class ContractType
    {
        public ContractType()
        {

        }
        public ContractType(double includedCreditPercentage, ServiceLevel serviceLevel, bool freeTechnicalSupport, string contractName)
        {
            IncludedCreditPercentage = includedCreditPercentage;
            FreeTechnicalSupport = freeTechnicalSupport;
            ContractName = contractName;
            ServiceLevel = serviceLevel;
        }

        public ContractType(string contractID, ServiceLevel serviceLevel, double includedCreditPercentage, bool freeTechnicalSupport, string contractName)
        {
            ContractID = contractID;
            IncludedCreditPercentage = includedCreditPercentage;
            FreeTechnicalSupport = freeTechnicalSupport;
            ContractName = contractName;
            ServiceLevel = serviceLevel;
        }

        [Key]
        public string ContractID { get; set; }
        public double IncludedCreditPercentage { get; set; }

        public ServiceLevel ServiceLevel { get; set; }
        public bool FreeTechnicalSupport { get; set; }
        public string ContractName { get; set; }
        public virtual List<Contract> Contracts { get; set; }
    }
}
