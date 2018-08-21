using BusinessLayer.io.customerManagement.enquiries.order;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.OrderRepository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public Order Get(int id, IEnumerable<Expression<Func<Order, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.TrackingNumber == id);
        }
    }
}
