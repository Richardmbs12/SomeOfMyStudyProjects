using System;
using System.Collections.Generic;
using System.Data;
using BusinessLayer.io.productManagement.product;
using DataAccessLayer.Persistance.DataHandler;

namespace DataAccessLayer.Persistance.PersistanceManagers.ProductPersistanceManager
{
    public class ProductPersistanceManager : IProductPersistanceManager
    {
        protected readonly IDataHandler dataHandler;
        public ProductPersistanceManager(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(string id)
        {
            Product product = null;
            DataSet productDataSet = dataHandler.ExecuteReturnStoredProcedure("sp_selectProductsAndTypesZ");

            productDataSet.Tables[0].TableName = "Product";
            productDataSet.Tables[1].TableName = "ProductType";


            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
