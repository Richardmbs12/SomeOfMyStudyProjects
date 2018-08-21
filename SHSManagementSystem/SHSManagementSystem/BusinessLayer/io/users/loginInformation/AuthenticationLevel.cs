using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.users.loginInformation
{
    public enum AuthenticationLevel
    {
        CustomerManagementDepartment = 0,
        ProductManagementDepartment = 1,
        TechnicalSupportManagementDepartment = 2,
        Administrator = 3
    };
}
