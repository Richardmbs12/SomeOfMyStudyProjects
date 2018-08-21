using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer
{
    public interface ICustomerRecordKeeper
    {
        CreateCustomerResponse CreateCustomer(CreateCustomerRequest createCustomerRequest);
        FindCustomerResponse FindCustomer(FindCustomerRequest findCustomerRequest);
        RemoveCustomerResponse RemoveCustomer(RemoveCustomerRequest removeCustomerRequest);
        RetrieveCustomerResponse RetrieveCustomer(RetrieveCustomerRequest retrieveCustomerRequest);
        UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest updateCustomerRequest);
    }

    [Serializable]
    public class CreateCustomerRequest
    {
        private Customer customer;
        public CreateCustomerRequest setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
    [Serializable]
    public class CreateCustomerResponse
    {
        private string error;
        public CreateCustomerResponse setError(string error)
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
    public class FindCustomerRequest
    {
        private SearchCriteria searchCriteria;
        public FindCustomerRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindCustomerResponse
    {
        private List<Customer> customers;
        private string error;
        public FindCustomerResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindCustomerResponse setCustomer(List<Customer> customers)
        {
            this.customers = customers;
            return this;
        }
        public List<Customer> getCustomers()
        {
            return this.customers;
        }
    }
    [Serializable]
    public class RemoveCustomerRequest
    {
        private Customer customer;
        public RemoveCustomerRequest setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
    [Serializable]
    public class RemoveCustomerResponse
    {
        private string error;
        public RemoveCustomerResponse setError(string error)
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
    public class RetrieveCustomerRequest
    {
        private string id;
        public RetrieveCustomerRequest setCustomerId(string id)
        {
            this.id = id;
            return this;
        }
        public string getCustomerId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveCustomerResponse
    {
        private Customer customer;
        private string error;
        public RetrieveCustomerResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveCustomerResponse setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
    [Serializable]
    public class UpdateCustomerRequest
    {
        private Customer customer;
        public UpdateCustomerRequest setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
    [Serializable]
    public class UpdateCustomerResponse
    {
        private Customer customer;
        private string error;
        public UpdateCustomerResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateCustomerResponse setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
    [Serializable]
    public class CustomerNotUnique : Exception
    {
        public CustomerNotUnique()
          : base()
        {
        }
        public CustomerNotUnique(String message)
          : base(message)
        {
        }
        public CustomerNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerAlreadyExists : Exception
    {
        public CustomerAlreadyExists()
          : base()
        {
        }
        public CustomerAlreadyExists(String message)
          : base(message)
        {
        }
        public CustomerAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerDoesNotExist : Exception
    {
        public CustomerDoesNotExist()
          : base()
        {
        }
        public CustomerDoesNotExist(String message)
          : base(message)
        {
        }
        public CustomerDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
