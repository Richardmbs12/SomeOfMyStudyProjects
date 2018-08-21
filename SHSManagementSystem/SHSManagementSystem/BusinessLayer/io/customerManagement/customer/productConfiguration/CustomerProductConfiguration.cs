using BusinessLayer.io.productManagement.product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.productConfiguration
{
    [Table("CustomerProductConfiguration")]
    public class CustomerProductConfiguration
    {
        public CustomerProductConfiguration(List<Product> installedProducts, string configurationNote)
        {
            InstalledProducts = installedProducts;
            ConfigurationNote = configurationNote;
        }
        public CustomerProductConfiguration()
        {

        }
        public string ConfigurationNote { get; set; }
        //EF
        public virtual List<Product> InstalledProducts { get; set; }
        [Key]
        [ForeignKey("Customer")]
        public string ID { get; set; }
        public Customer Customer { get; set; }

    }
}
