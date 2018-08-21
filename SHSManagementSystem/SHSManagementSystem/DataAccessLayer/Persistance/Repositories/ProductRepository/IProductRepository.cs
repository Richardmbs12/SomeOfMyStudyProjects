using BusinessLayer.io.productManagement.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ProductRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product Get(int id, IEnumerable<Expression<Func<Product, object>>> includes);
    }
}
