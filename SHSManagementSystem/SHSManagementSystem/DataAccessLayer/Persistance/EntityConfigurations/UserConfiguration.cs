using BusinessLayer.io.users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasRequired(c => c.Address)
            .WithRequiredPrincipal(a => a.User);

            HasRequired(c => c.ContactInformation)
            .WithRequiredPrincipal(ci => ci.User);
        }
    }
}
