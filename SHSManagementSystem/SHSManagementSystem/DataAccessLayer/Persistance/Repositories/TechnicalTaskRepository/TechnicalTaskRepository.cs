using BusinessLayer.io.technicalSupport.technicalTask;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.TechnicalTaskRepository
{
    public class TechnicalTaskRepository : Repository<TechnicalTask> , ITechnicalTaskRepository
    {
        public TechnicalTaskRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public TechnicalTask Get(int id, IEnumerable<Expression<Func<TechnicalTask, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.TrackingNumber == id);
        }
    }
}
