using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using BusinessLayer.io.productManagement.product;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.customerManagement.customer.productConfiguration
{
    [Table("ProductInstallationHistory")]
    public class ProductInstallationHistory
    {
        public ProductInstallationHistory(bool installed, string installationNote, DateTime installationDate, TechnicalSupportManagementEmployee installationEmployee)
        {
            Installed = installed;
            InstallationNote = installationNote;
            InstallationDate = installationDate;
            InstallationEmployee = installationEmployee;
        }
        public ProductInstallationHistory()
        {

        }
        public DateTime InstallationDate { get; set; }
        public string InstallationNote { get; set; }
        public bool Installed { get; set; }
        //EF
        public virtual TechnicalSupportManagementEmployee InstallationEmployee { get; set; }
        [Key]
        [ForeignKey("Product")]
        public int SerialNumber { get; set; }
        public virtual Product Product { get; set; }
    }
}
