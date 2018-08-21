using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.billingInvoiceManagement.billingInvoice.billing
{
    public interface IBillingInvoiceRecordKeeper
    {
        CreateBillingInvoiceResponse CreateBillingInvoice(CreateBillingInvoiceRequest createBillingInvoiceRequest);
        FindBillingInvoiceResponse FindBillingInvoice(FindBillingInvoiceRequest findBillingInvoiceRequest);
        RemoveBillingInvoiceResponse RemoveBillingInvoice(RemoveBillingInvoiceRequest removeBillingInvoiceRequest);
        RetrieveBillingInvoiceResponse RetrieveBillingInvoice(RetrieveBillingInvoiceRequest retrieveBillingInvoiceRequest);
        UpdateBillingInvoiceResponse UpdateBillingInvoice(UpdateBillingInvoiceRequest updateBillingInvoiceRequest);
    }

    [Serializable]
    public class CreateBillingInvoiceRequest
    {
        private BillingInvoice billingInvoice;
        public CreateBillingInvoiceRequest setBillingInvoice(BillingInvoice billingInvoice)
        {
            this.billingInvoice = billingInvoice;
            return this;
        }
        public BillingInvoice getBillingInvoice()
        {
            return this.billingInvoice;
        }
    }
    [Serializable]
    public class CreateBillingInvoiceResponse
    {
        private string error;
        public CreateBillingInvoiceResponse setError(string error)
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
    public class FindBillingInvoiceRequest
    {
        private SearchCriteria searchCriteria;
        public FindBillingInvoiceRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindBillingInvoiceResponse
    {
        private List<BillingInvoice> billingInvoices;
        private string error;
        public FindBillingInvoiceResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindBillingInvoiceResponse setBillingInvoice(List<BillingInvoice> billingInvoices)
        {
            this.billingInvoices = billingInvoices;
            return this;
        }
        public List<BillingInvoice> getBillingInvoices()
        {
            return this.billingInvoices;
        }
    }
    [Serializable]
    public class RemoveBillingInvoiceRequest
    {
        private BillingInvoice billingInvoice;
        public RemoveBillingInvoiceRequest setBillingInvoice(BillingInvoice billingInvoice)
        {
            this.billingInvoice = billingInvoice;
            return this;
        }
        public BillingInvoice getBillingInvoice()
        {
            return this.billingInvoice;
        }
    }
    [Serializable]
    public class RemoveBillingInvoiceResponse
    {
        private string error;
        public RemoveBillingInvoiceResponse setError(string error)
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
    public class RetrieveBillingInvoiceRequest
    {
        private int id;
        public RetrieveBillingInvoiceRequest setBillingInvoiceId(int id)
        {
            this.id = id;
            return this;
        }
        public int getBillingInvoiceId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveBillingInvoiceResponse
    {
        private BillingInvoice billingInvoice;
        private string error;
        public RetrieveBillingInvoiceResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveBillingInvoiceResponse setBillingInvoice(BillingInvoice billingInvoice)
        {
            this.billingInvoice = billingInvoice;
            return this;
        }
        public BillingInvoice getBillingInvoice()
        {
            return this.billingInvoice;
        }
    }
    [Serializable]
    public class UpdateBillingInvoiceRequest
    {
        private int id;
        private BillingInvoice billingInvoice;
        public UpdateBillingInvoiceRequest setBillingInvoice(BillingInvoice billingInvoice)
        {
            this.billingInvoice = billingInvoice;
            return this;
        }
        public BillingInvoice getBillingInvoice()
        {
            return this.billingInvoice;
        }
        public UpdateBillingInvoiceRequest setBillingInvoiceId(int id)
        {
            this.id = id;
            return this;
        }
        public int getBillingInvoiceIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateBillingInvoiceResponse
    {
        private BillingInvoice billingInvoice;
        private string error;
        public UpdateBillingInvoiceResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateBillingInvoiceResponse setBillingInvoice(BillingInvoice billingInvoice)
        {
            this.billingInvoice = billingInvoice;
            return this;
        }
        public BillingInvoice getBillingInvoice()
        {
            return this.billingInvoice;
        }
    }
    [Serializable]
    public class BillingInvoiceNotUnique : Exception
    {
        public BillingInvoiceNotUnique()
          : base()
        {
        }
        public BillingInvoiceNotUnique(String message)
          : base(message)
        {
        }
        public BillingInvoiceNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected BillingInvoiceNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class BillingInvoiceAlreadyExists : Exception
    {
        public BillingInvoiceAlreadyExists()
          : base()
        {
        }
        public BillingInvoiceAlreadyExists(String message)
          : base(message)
        {
        }
        public BillingInvoiceAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected BillingInvoiceAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class BillingInvoiceDoesNotExist : Exception
    {
        public BillingInvoiceDoesNotExist()
          : base()
        {
        }
        public BillingInvoiceDoesNotExist(String message)
          : base(message)
        {
        }
        public BillingInvoiceDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected BillingInvoiceDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
