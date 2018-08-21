using BusinessLayer.io.customerManagement.enquiries.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.OrderRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order Get(int id, IEnumerable<Expression<Func<Order, object>>> includes);
    }
}
