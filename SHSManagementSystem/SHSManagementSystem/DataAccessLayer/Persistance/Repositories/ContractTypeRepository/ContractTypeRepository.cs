using BusinessLayer.io.customerManagement.customer.contract;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ContractTypeRepository
{
    public class ContractTypeRepository : Repository<ContractType>, IContractTypeRepository
    {
        public ContractTypeRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public ContractType Get(string id, IEnumerable<Expression<Func<ContractType, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ContractID == id);
        }
    }
}
