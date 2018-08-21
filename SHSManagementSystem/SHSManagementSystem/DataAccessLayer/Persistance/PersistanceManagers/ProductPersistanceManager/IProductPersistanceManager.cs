using BusinessLayer.io.productManagement.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistance.PersistanceManagers.ProductPersistanceManager
{
    interface IProductPersistanceManager
    {
        Product Get(string id);

        IEnumerable<Product> GetAll();

        void Add(Product product);

        void Remove(Product product);

        void SaveChanges(Product product);
    }
}
