using BusinessLayer.io.employeeManagement.customerManagementEmployee;
using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BusinessLayer.io.customerManagementEmployeeManagement.customerManagementCustomerManagementEmployee
{
    public interface ICustomerManagementEmployeeRecordKeeper
    {
        CreateCustomerManagementEmployeeResponse CreateCustomerManagementEmployee(CreateCustomerManagementEmployeeRequest createCustomerManagementEmployeeRequest);
        FindCustomerManagementEmployeeResponse FindCustomerManagementEmployee(FindCustomerManagementEmployeeRequest findCustomerManagementEmployeeRequest);
        RemoveCustomerManagementEmployeeResponse RemoveCustomerManagementEmployee(RemoveCustomerManagementEmployeeRequest removeCustomerManagementEmployeeRequest);
        RetrieveCustomerManagementEmployeeResponse RetrieveCustomerManagementEmployee(RetrieveCustomerManagementEmployeeRequest retrieveCustomerManagementEmployeeRequest);
        UpdateCustomerManagementEmployeeResponse UpdateCustomerManagementEmployee(UpdateCustomerManagementEmployeeRequest updateCustomerManagementEmployeeRequest);
    }

    [Serializable]
    public class CreateCustomerManagementEmployeeRequest
    {
        private CustomerManagementEmployee customerManagementEmployee;
        public CreateCustomerManagementEmployeeRequest setCustomerManagementEmployee(CustomerManagementEmployee customerManagementEmployee)
        {
            this.customerManagementEmployee = customerManagementEmployee;
            return this;
        }
        public CustomerManagementEmployee getCustomerManagementEmployee()
        {
            return this.customerManagementEmployee;
        }
    }
    [Serializable]
    public class CreateCustomerManagementEmployeeResponse
    {
        private string error;
        public CreateCustomerManagementEmployeeResponse setError(string error)
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
    public class FindCustomerManagementEmployeeRequest
    {
        private SearchCriteria searchCriteria;
        public FindCustomerManagementEmployeeRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindCustomerManagementEmployeeResponse
    {
        private List<CustomerManagementEmployee> customerManagementEmployees;
        private string error;
        public FindCustomerManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindCustomerManagementEmployeeResponse setCustomerManagementEmployee(List<CustomerManagementEmployee> customerManagementEmployees)
        {
            this.customerManagementEmployees = customerManagementEmployees;
            return this;
        }
        public List<CustomerManagementEmployee> getCustomerManagementEmployees()
        {
            return this.customerManagementEmployees;
        }
    }
    [Serializable]
    public class RemoveCustomerManagementEmployeeRequest
    {
        private CustomerManagementEmployee customerManagementEmployee;
        public RemoveCustomerManagementEmployeeRequest setCustomerManagementEmployee(CustomerManagementEmployee customerManagementEmployee)
        {
            this.customerManagementEmployee = customerManagementEmployee;
            return this;
        }
        public CustomerManagementEmployee getCustomerManagementEmployee()
        {
            return this.customerManagementEmployee;
        }
    }
    [Serializable]
    public class RemoveCustomerManagementEmployeeResponse
    {
        private string error;
        public RemoveCustomerManagementEmployeeResponse setError(string error)
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
    public class RetrieveCustomerManagementEmployeeRequest
    {
        private string id;
        public RetrieveCustomerManagementEmployeeRequest setCustomerManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getCustomerManagementEmployeeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveCustomerManagementEmployeeResponse
    {
        private CustomerManagementEmployee customerManagementEmployee;
        private string error;
        public RetrieveCustomerManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveCustomerManagementEmployeeResponse setCustomerManagementEmployee(CustomerManagementEmployee customerManagementEmployee)
        {
            this.customerManagementEmployee = customerManagementEmployee;
            return this;
        }
        public CustomerManagementEmployee getCustomerManagementEmployee()
        {
            return this.customerManagementEmployee;
        }
    }
    [Serializable]
    public class UpdateCustomerManagementEmployeeRequest
    {
        private string id;
        private CustomerManagementEmployee customerManagementEmployee;
        public UpdateCustomerManagementEmployeeRequest setCustomerManagementEmployee(CustomerManagementEmployee customerManagementEmployee)
        {
            this.customerManagementEmployee = customerManagementEmployee;
            return this;
        }
        public CustomerManagementEmployee getCustomerManagementEmployee()
        {
            return this.customerManagementEmployee;
        }
        public UpdateCustomerManagementEmployeeRequest setCustomerManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getCustomerManagementEmployeeIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateCustomerManagementEmployeeResponse
    {
        private CustomerManagementEmployee customerManagementEmployee;
        private string error;
        public UpdateCustomerManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateCustomerManagementEmployeeResponse setCustomerManagementEmployee(CustomerManagementEmployee customerManagementEmployee)
        {
            this.customerManagementEmployee = customerManagementEmployee;
            return this;
        }
        public CustomerManagementEmployee getCustomerManagementEmployee()
        {
            return this.customerManagementEmployee;
        }
    }
    [Serializable]
    public class CustomerManagementEmployeeNotUnique : Exception
    {
        public CustomerManagementEmployeeNotUnique()
          : base()
        {
        }
        public CustomerManagementEmployeeNotUnique(String message)
          : base(message)
        {
        }
        public CustomerManagementEmployeeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerManagementEmployeeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerManagementEmployeeAlreadyExists : Exception
    {
        public CustomerManagementEmployeeAlreadyExists()
          : base()
        {
        }
        public CustomerManagementEmployeeAlreadyExists(String message)
          : base(message)
        {
        }
        public CustomerManagementEmployeeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerManagementEmployeeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerManagementEmployeeDoesNotExist : Exception
    {
        public CustomerManagementEmployeeDoesNotExist()
          : base()
        {
        }
        public CustomerManagementEmployeeDoesNotExist(String message)
          : base(message)
        {
        }
        public CustomerManagementEmployeeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerManagementEmployeeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
