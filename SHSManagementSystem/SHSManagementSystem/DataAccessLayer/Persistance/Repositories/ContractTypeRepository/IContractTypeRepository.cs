using BusinessLayer.io.customerManagement.customer.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ContractTypeRepository
{
    public interface IContractTypeRepository : IRepository<ContractType>
    {
        ContractType Get(string id, IEnumerable<Expression<Func<ContractType, object>>> includes);
    }
}
