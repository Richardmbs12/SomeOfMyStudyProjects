using BusinessLayer.io.technicalSupport.schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ScheduleRepository
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Schedule Get(int id, IEnumerable<Expression<Func<Schedule, object>>> includes);
    }
}
