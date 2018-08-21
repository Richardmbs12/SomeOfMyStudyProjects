using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerEnquiryManagement.enquiries
{
    public interface ICustomerEnquiryRecordKeeper
    {
        CreateCustomerEnquiryResponse CreateCustomerEnquiry(CreateCustomerEnquiryRequest createCustomerEnquiryRequest);
        FindCustomerEnquiryResponse FindCustomerEnquiry(FindCustomerEnquiryRequest findCustomerEnquiryRequest);
        RemoveCustomerEnquiryResponse RemoveCustomerEnquiry(RemoveCustomerEnquiryRequest removeCustomerEnquiryRequest);
        RetrieveCustomerEnquiryResponse RetrieveCustomerEnquiry(RetrieveCustomerEnquiryRequest retrieveCustomerEnquiryRequest);
        UpdateCustomerEnquiryResponse UpdateCustomerEnquiry(UpdateCustomerEnquiryRequest updateCustomerEnquiryRequest);
    }

    [Serializable]
    public class CreateCustomerEnquiryRequest
    {
        private CustomerEnquiry customerEnquiry;
        public CreateCustomerEnquiryRequest setCustomerEnquiry(CustomerEnquiry customerEnquiry)
        {
            this.customerEnquiry = customerEnquiry;
            return this;
        }
        public CustomerEnquiry getCustomerEnquiry()
        {
            return this.customerEnquiry;
        }
    }
    [Serializable]
    public class CreateCustomerEnquiryResponse
    {
        private string error;
        public CreateCustomerEnquiryResponse setError(string error)
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
    public class FindCustomerEnquiryRequest
    {
        private SearchCriteria searchCriteria;
        public FindCustomerEnquiryRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindCustomerEnquiryResponse
    {
        private List<CustomerEnquiry> customerEnquiries;
        private string error;
        public FindCustomerEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindCustomerEnquiryResponse setCustomerEnquiries(List<CustomerEnquiry> customerEnquiries)
        {
            this.customerEnquiries = customerEnquiries;
            return this;
        }
        public List<CustomerEnquiry> getCustomerEnquiries()
        {
            return this.customerEnquiries;
        }
    }
    [Serializable]
    public class RemoveCustomerEnquiryRequest
    {
        private CustomerEnquiry customerEnquiry;
        public RemoveCustomerEnquiryRequest setCustomerEnquiry(CustomerEnquiry customerEnquiry)
        {
            this.customerEnquiry = customerEnquiry;
            return this;
        }
        public CustomerEnquiry getCustomerEnquiry()
        {
            return this.customerEnquiry;
        }
    }
    [Serializable]
    public class RemoveCustomerEnquiryResponse
    {
        private string error;
        public RemoveCustomerEnquiryResponse setError(string error)
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
    public class RetrieveCustomerEnquiryRequest
    {
        private int trackingNumber;
        public RetrieveCustomerEnquiryRequest setCustomerEnquiryTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getCustomerEnquiryTrackingNumber()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class RetrieveCustomerEnquiryResponse
    {
        private CustomerEnquiry customerEnquiry;
        private string error;
        public RetrieveCustomerEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveCustomerEnquiryResponse setCustomerEnquiry(CustomerEnquiry customerEnquiry)
        {
            this.customerEnquiry = customerEnquiry;
            return this;
        }
        public CustomerEnquiry getCustomerEnquiry()
        {
            return this.customerEnquiry;
        }
    }
    [Serializable]
    public class UpdateCustomerEnquiryRequest
    {
        private int trackingNumber;
        private CustomerEnquiry customerEnquiry;
        public UpdateCustomerEnquiryRequest setCustomerEnquiry(CustomerEnquiry customerEnquiry)
        {
            this.customerEnquiry = customerEnquiry;
            return this;
        }
        public CustomerEnquiry getCustomerEnquiry()
        {
            return this.customerEnquiry;
        }
        public UpdateCustomerEnquiryRequest setCustomerEnquiryTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getCustomerEnquiryTrackingNumber()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class UpdateCustomerEnquiryResponse
    {
        private CustomerEnquiry customerEnquiry;
        private string error;
        public UpdateCustomerEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateCustomerEnquiryResponse setCustomerEnquiry(CustomerEnquiry customerEnquiry)
        {
            this.customerEnquiry = customerEnquiry;
            return this;
        }
        public CustomerEnquiry getCustomerEnquiry()
        {
            return this.customerEnquiry;
        }
    }
    [Serializable]
    public class CustomerEnquiryNotUnique : Exception
    {
        public CustomerEnquiryNotUnique()
          : base()
        {
        }
        public CustomerEnquiryNotUnique(String message)
          : base(message)
        {
        }
        public CustomerEnquiryNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerEnquiryNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerEnquiryAlreadyExists : Exception
    {
        public CustomerEnquiryAlreadyExists()
          : base()
        {
        }
        public CustomerEnquiryAlreadyExists(String message)
          : base(message)
        {
        }
        public CustomerEnquiryAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerEnquiryAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class CustomerEnquiryDoesNotExist : Exception
    {
        public CustomerEnquiryDoesNotExist()
          : base()
        {
        }
        public CustomerEnquiryDoesNotExist(String message)
          : base(message)
        {
        }
        public CustomerEnquiryDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected CustomerEnquiryDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
