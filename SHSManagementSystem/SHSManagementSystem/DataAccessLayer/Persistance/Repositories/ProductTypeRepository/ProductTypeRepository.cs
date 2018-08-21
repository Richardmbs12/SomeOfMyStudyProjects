using BusinessLayer.io.productManagement.productType;
using DataAccessLayer.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.ProductTypeRepository
{
    class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(SHSDatabaseContext context)
            : base(context)
        {
        }

        public SHSDatabaseContext SHSDatabaseContext
        {
            get { return Context as SHSDatabaseContext; }
        }

        public ProductType Get(int id, IEnumerable<Expression<Func<ProductType, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Single(x => x.ProductID == id);
        }
    }
}
