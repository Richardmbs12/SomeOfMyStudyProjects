using BusinessLayer.io.productManagement.product;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.Repositories.ProductRepository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SHSDatabaseContext context)
        : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public Product Get(int id, IEnumerable<Expression<Func<Product, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.SerialNumber == id);
        }
    }
}
