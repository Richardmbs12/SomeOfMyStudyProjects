using BusinessLayer.io.technicalSupport.schedule;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ScheduleRepository
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public Schedule Get(int id, IEnumerable<Expression<Func<Schedule, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ScheduleID == id);
        }
    }
}
