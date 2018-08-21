using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.employeeManagement.productManagementEmployee
{
    public interface IProductManagementEmployeeRecordKeeper
    {
        CreateProductManagementEmployeeResponse CreateProductManagementEmployee(CreateProductManagementEmployeeRequest createProductManagementEmployeeRequest);
        FindProductManagementEmployeeResponse FindProductManagementEmployee(FindProductManagementEmployeeRequest findProductManagementEmployeeRequest);
        RemoveProductManagementEmployeeResponse RemoveProductManagementEmployee(RemoveProductManagementEmployeeRequest removeProductManagementEmployeeRequest);
        RetrieveProductManagementEmployeeResponse RetrieveProductManagementEmployee(RetrieveProductManagementEmployeeRequest retrieveProductManagementEmployeeRequest);
        UpdateProductManagementEmployeeResponse UpdateProductManagementEmployee(UpdateProductManagementEmployeeRequest updateProductManagementEmployeeRequest);
    }

    [Serializable]
    public class CreateProductManagementEmployeeRequest
    {
        private ProductManagementEmployee productManagementEmployee;
        public CreateProductManagementEmployeeRequest setProductManagementEmployee(ProductManagementEmployee productManagementEmployee)
        {
            this.productManagementEmployee = productManagementEmployee;
            return this;
        }
        public ProductManagementEmployee getProductManagementEmployee()
        {
            return this.productManagementEmployee;
        }
    }
    [Serializable]
    public class CreateProductManagementEmployeeResponse
    {
        private string error;
        public CreateProductManagementEmployeeResponse setError(string error)
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
    public class FindProductManagementEmployeeRequest
    {
        private SearchCriteria searchCriteria;
        public FindProductManagementEmployeeRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindProductManagementEmployeeResponse
    {
        private List<ProductManagementEmployee> productManagementEmployees;
        private string error;
        public FindProductManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindProductManagementEmployeeResponse setProductManagementEmployee(List<ProductManagementEmployee> productManagementEmployees)
        {
            this.productManagementEmployees = productManagementEmployees;
            return this;
        }
        public List<ProductManagementEmployee> getProductManagementEmployees()
        {
            return this.productManagementEmployees;
        }
    }
    [Serializable]
    public class RemoveProductManagementEmployeeRequest
    {
        private ProductManagementEmployee productManagementEmployee;
        public RemoveProductManagementEmployeeRequest setProductManagementEmployee(ProductManagementEmployee productManagementEmployee)
        {
            this.productManagementEmployee = productManagementEmployee;
            return this;
        }
        public ProductManagementEmployee getProductManagementEmployee()
        {
            return this.productManagementEmployee;
        }
    }
    [Serializable]
    public class RemoveProductManagementEmployeeResponse
    {
        private string error;
        public RemoveProductManagementEmployeeResponse setError(string error)
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
    public class RetrieveProductManagementEmployeeRequest
    {
        private string id;
        public RetrieveProductManagementEmployeeRequest setProductManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getProductManagementEmployeeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveProductManagementEmployeeResponse
    {
        private ProductManagementEmployee productManagementEmployee;
        private string error;
        public RetrieveProductManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveProductManagementEmployeeResponse setProductManagementEmployee(ProductManagementEmployee productManagementEmployee)
        {
            this.productManagementEmployee = productManagementEmployee;
            return this;
        }
        public ProductManagementEmployee getProductManagementEmployee()
        {
            return this.productManagementEmployee;
        }
    }
    [Serializable]
    public class UpdateProductManagementEmployeeRequest
    {
        private string id;
        private ProductManagementEmployee productManagementEmployee;
        public UpdateProductManagementEmployeeRequest setProductManagementEmployee(ProductManagementEmployee productManagementEmployee)
        {
            this.productManagementEmployee = productManagementEmployee;
            return this;
        }
        public ProductManagementEmployee getProductManagementEmployee()
        {
            return this.productManagementEmployee;
        }
        public UpdateProductManagementEmployeeRequest setProductManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getProductManagementEmployeeIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateProductManagementEmployeeResponse
    {
        private ProductManagementEmployee productManagementEmployee;
        private string error;
        public UpdateProductManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateProductManagementEmployeeResponse setProductManagementEmployee(ProductManagementEmployee productManagementEmployee)
        {
            this.productManagementEmployee = productManagementEmployee;
            return this;
        }
        public ProductManagementEmployee getProductManagementEmployee()
        {
            return this.productManagementEmployee;
        }
    }
    [Serializable]
    public class ProductManagementEmployeeNotUnique : Exception
    {
        public ProductManagementEmployeeNotUnique()
          : base()
        {
        }
        public ProductManagementEmployeeNotUnique(String message)
          : base(message)
        {
        }
        public ProductManagementEmployeeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductManagementEmployeeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductManagementEmployeeAlreadyExists : Exception
    {
        public ProductManagementEmployeeAlreadyExists()
          : base()
        {
        }
        public ProductManagementEmployeeAlreadyExists(String message)
          : base(message)
        {
        }
        public ProductManagementEmployeeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductManagementEmployeeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ProductManagementEmployeeDoesNotExist : Exception
    {
        public ProductManagementEmployeeDoesNotExist()
          : base()
        {
        }
        public ProductManagementEmployeeDoesNotExist(String message)
          : base(message)
        {
        }
        public ProductManagementEmployeeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ProductManagementEmployeeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
