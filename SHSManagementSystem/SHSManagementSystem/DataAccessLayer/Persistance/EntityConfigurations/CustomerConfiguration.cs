using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using BusinessLayer.io.customerManagement.customer;

namespace DataAccessLayer.Persistance.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {

            HasRequired(c => c.BillingInformation)
            .WithRequiredPrincipal(b => b.Customer);

            HasRequired(c => c.ProductConfiguration)
            .WithRequiredPrincipal(b => b.Customer);

            HasMany(c => c.CustomerEnquiries);
        }
    }
}
