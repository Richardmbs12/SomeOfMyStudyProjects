using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.productManagement.productType
{
    public interface IProductTypeRecordKeeper
    {
        CreateProductTypeResponse CreateProductType(CreateProductTypeRequest createProductTypeRequest);
        FindProductTypeResponse FindProductType(FindProductTypeRequest findProductTypeRequest);
        RemoveProductTypeResponse RemoveProductType(RemoveProductTypeRequest removeProductTypeRequest);
        RetrieveProductTypeResponse RetrieveProductType(RetrieveProductTypeRequest retrieveProductTypeRequest);
        UpdateProductTypeResponse UpdateProductType(UpdateProductTypeRequest updateProductTypeRequest);
    }

    [Serializable]
    public class CreateProductTypeRequest
    {
        private ProductType productType;
        public CreateProductTypeRequest setProductType(ProductType productType)
        {
            this.productType = productType;
            return this;
        }
        public ProductType getProductType()
        {
            return this.productType;
        }
    }
    [Serializable]
    public class CreateProductTypeResponse
    {
        private string error;
        public CreateProductTypeResponse setError(string error)
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
    public class FindProductTypeRequest
    {
        private SearchCriteria searchCriteria;
        public FindProductTypeRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindProductTypeResponse
    {
        private List<ProductType> productTypes;
        private string error;
        public FindProductTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindProductTypeResponse setProductType(List<ProductType> productTypes)
        {
            this.productTypes = productTypes;
            return this;
        }
        public List<ProductType> getProductTypes()
        {
            return this.productTypes;
        }
    }
    [Serializable]
    public class RemoveProductTypeRequest
    {
        private ProductType productType;
        public RemoveProductTypeRequest setProductType(ProductType productType)
        {
            this.productType = productType;
            return this;
        }
        public ProductType getProductType()
        {
            return this.productType;
        }
    }
    [Serializable]
    public class RemoveProductTypeResponse
    {
        private string error;
        public RemoveProductTypeResponse setError(string error)
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
    public class RetrieveProductTypeRequest
    {
        private int id;
        public RetrieveProductTypeRequest setProductTypeId(int id)
        {
            this.id = id;
            return this;
        }
        public int getProductTypeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveProductTypeResponse
    {
        private ProductType productType;
        private string error;
        public RetrieveProductTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveProductTypeResponse setProductType(ProductType productType)
        {
            this.productType = productType;
            return this;
        }
        public ProductType getProductType()
        {
            return this.productType;
        }
    }
    [Serializable]
    public class UpdateProductTypeRequest
    {
        private int id;
        private ProductType productType;
        public UpdateProductTypeRequest setProductType(ProductType productType)
        {
            this.productType = productType;
            return this;
        }
        public ProductType getProductType()
        {
            return this.productType;
        }
        public UpdateProductTypeRequest setProductTypeId(int id)
        {
            this.id = id;
            return this;
        }
        public int getProductTypeIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateProductTypeResponse
    {
        private ProductType productType;
        private string error;
        public UpdateProductTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateProductTypeResponse setProductType(ProductType productType)
        {
            this.productType = productType;
            return this;
        }
        public ProductType getProductType()
        {
            return this.productType;
        }
    }
    [Serializable]
    public class ProductTypeNotUnique : Exception
    {
        public ProductTypeNotUnique()
          : base()
        {
        }
        public ProductTypeNotUnique(String message)
          : base(message)
        {
        }
        public ProductTypeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductTypeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductTypeAlreadyExists : Exception
    {
        public ProductTypeAlreadyExists()
          : base()
        {
        }
        public ProductTypeAlreadyExists(String message)
          : base(message)
        {
        }
        public ProductTypeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductTypeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductTypeDoesNotExist : Exception
    {
        public ProductTypeDoesNotExist()
          : base()
        {
        }
        public ProductTypeDoesNotExist(String message)
          : base(message)
        {
        }
        public ProductTypeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductTypeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
