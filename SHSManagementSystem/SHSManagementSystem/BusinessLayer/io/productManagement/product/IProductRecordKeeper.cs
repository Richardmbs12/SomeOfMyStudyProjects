using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.productManagement.product
{
    public interface IProductRecordKeeper
    {
        CreateProductResponse CreateProduct(CreateProductRequest createProductRequest);
        FindProductResponse FindProduct(FindProductRequest findProductRequest);
        RemoveProductResponse RemoveProduct(RemoveProductRequest removeProductRequest);
        RetrieveProductResponse RetrieveProduct(RetrieveProductRequest retrieveProductRequest);
        UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest);
    }

    [Serializable]
    public class CreateProductRequest
    {
        private Product product;
        public CreateProductRequest setProduct(Product product)
        {
            this.product = product;
            return this;
        }
        public Product getProduct()
        {
            return this.product;
        }
    }
    [Serializable]
    public class CreateProductResponse
    {
        private string error;
        public CreateProductResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class FindProductRequest
    {
        private SearchCriteria searchCriteria;
        public FindProductRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
        public SearchCriteria getSearchCriteria()
        {
            return this.searchCriteria;
        }
    }
    [Serializable]
    public class FindProductResponse
    {
        private List<Product> products;
        private string error;
        public FindProductResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindProductResponse setProduct(List<Product> products)
        {
            this.products = products;
            return this;
        }
        public List<Product> getProducts()
        {
            return this.products;
        }
    }
    [Serializable]
    public class RemoveProductRequest
    {
        private Product product;
        public RemoveProductRequest setProduct(Product product)
        {
            this.product = product;
            return this;
        }
        public Product getProduct()
        {
            return this.product;
        }
    }
    [Serializable]
    public class RemoveProductResponse
    {
        private string error;
        public RemoveProductResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class RetrieveProductRequest
    {
        private int serialNumber;
        public RetrieveProductRequest setProductSerialNumber(int serialNumber)
        {
            this.serialNumber = serialNumber;
            return this;
        }
        public int getProductSerialNumber()
        {
            return this.serialNumber;
        }
    }
    [Serializable]
    public class RetrieveProductResponse
    {
        private Product product;
        private string error;
        public RetrieveProductResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveProductResponse setProduct(Product product)
        {
            this.product = product;
            return this;
        }
        public Product getProduct()
        {
            return this.product;
        }
    }
    [Serializable]
    public class UpdateProductRequest
    {
        private int serialNumber;
        private Product product;
        public UpdateProductRequest setProduct(Product product)
        {
            this.product = product;
            return this;
        }
        public Product getProduct()
        {
            return this.product;
        }
        public UpdateProductRequest setProductSerialNumber(int serialNumber)
        {
            this.serialNumber = serialNumber;
            return this;
        }
        public int getProductSerialNumberentifier()
        {
            return this.serialNumber;
        }
    }
    [Serializable]
    public class UpdateProductResponse
    {
        private Product product;
        private string error;
        public UpdateProductResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateProductResponse setProduct(Product product)
        {
            this.product = product;
            return this;
        }
        public Product getProduct()
        {
            return this.product;
        }
    }
    [Serializable]
    public class ProductNotUnique : Exception
    {
        public ProductNotUnique()
          : base()
        {
        }
        public ProductNotUnique(String message)
          : base(message)
        {
        }
        public ProductNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductAlreadyExists : Exception
    {
        public ProductAlreadyExists()
          : base()
        {
        }
        public ProductAlreadyExists(String message)
          : base(message)
        {
        }
        public ProductAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductDoesNotExist : Exception
    {
        public ProductDoesNotExist()
          : base()
        {
        }
        public ProductDoesNotExist(String message)
          : base(message)
        {
        }
        public ProductDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
