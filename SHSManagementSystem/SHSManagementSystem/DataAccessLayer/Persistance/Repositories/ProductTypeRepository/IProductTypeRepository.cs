using BusinessLayer.io.productManagement.productType;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories.ProductTypeRepository
{
    public interface IProductTypeRepository : IRepository<ProductType>
    {
        ProductType Get(int id, IEnumerable<Expression<Func<ProductType, object>>> includes);
    }
}
