using BusinessLayer.io.technicalSupport.technicalTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.TechnicalTaskRepository
{
    public interface ITechnicalTaskRepository : IRepository<TechnicalTask>
    {
        TechnicalTask Get(int id, IEnumerable<Expression<Func<TechnicalTask, object>>> includes);
    }
}
