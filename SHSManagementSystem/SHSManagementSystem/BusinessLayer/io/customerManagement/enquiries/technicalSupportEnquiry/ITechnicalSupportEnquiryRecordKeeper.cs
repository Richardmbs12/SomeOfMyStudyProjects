using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiryEnquiry
{
    public interface ITechnicalSupportEnquiryRecordKeeper
    {
        CreateTechnicalSupportEnquiryResponse CreateTechnicalSupportEnquiry(CreateTechnicalSupportEnquiryRequest createTechnicalSupportEnquiryRequest);
        FindTechnicalSupportEnquiryResponse FindTechnicalSupportEnquiry(FindTechnicalSupportEnquiryRequest findTechnicalSupportEnquiryRequest);
        RemoveTechnicalSupportEnquiryResponse RemoveTechnicalSupportEnquiry(RemoveTechnicalSupportEnquiryRequest removeTechnicalSupportEnquiryRequest);
        RetrieveTechnicalSupportEnquiryResponse RetrieveTechnicalSupportEnquiry(RetrieveTechnicalSupportEnquiryRequest retrieveTechnicalSupportEnquiryRequest);
        UpdateTechnicalSupportEnquiryResponse UpdateTechnicalSupportEnquiry(UpdateTechnicalSupportEnquiryRequest updateTechnicalSupportEnquiryRequest);
    }

    [Serializable]
    public class CreateTechnicalSupportEnquiryRequest
    {
        private TechnicalSupportEnquiry technicalSupportEnquiry;
        public CreateTechnicalSupportEnquiryRequest setTechnicalSupportEnquiry(TechnicalSupportEnquiry technicalSupportEnquiry)
        {
            this.technicalSupportEnquiry = technicalSupportEnquiry;
            return this;
        }
        public TechnicalSupportEnquiry getTechnicalSupportEnquiry()
        {
            return this.technicalSupportEnquiry;
        }
    }
    [Serializable]
    public class CreateTechnicalSupportEnquiryResponse
    {
        private string error;
        public CreateTechnicalSupportEnquiryResponse setError(string error)
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
    public class FindTechnicalSupportEnquiryRequest
    {
        private SearchCriteria searchCriteria;
        public FindTechnicalSupportEnquiryRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindTechnicalSupportEnquiryResponse
    {
        private List<TechnicalSupportEnquiry> technicalSupportEnquiries;
        private string error;
        public FindTechnicalSupportEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindTechnicalSupportEnquiryResponse setTechnicalSupportEnquiry(List<TechnicalSupportEnquiry> technicalSupportEnquiries)
        {
            this.technicalSupportEnquiries = technicalSupportEnquiries;
            return this;
        }
        public List<TechnicalSupportEnquiry> getTechnicalSupportEnquiries()
        {
            return this.technicalSupportEnquiries;
        }
    }
    [Serializable]
    public class RemoveTechnicalSupportEnquiryRequest
    {
        private TechnicalSupportEnquiry technicalSupportEnquiry;
        public RemoveTechnicalSupportEnquiryRequest setTechnicalSupportEnquiry(TechnicalSupportEnquiry technicalSupportEnquiry)
        {
            this.technicalSupportEnquiry = technicalSupportEnquiry;
            return this;
        }
        public TechnicalSupportEnquiry getTechnicalSupportEnquiry()
        {
            return this.technicalSupportEnquiry;
        }
    }
    [Serializable]
    public class RemoveTechnicalSupportEnquiryResponse
    {
        private string error;
        public RemoveTechnicalSupportEnquiryResponse setError(string error)
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
    public class RetrieveTechnicalSupportEnquiryRequest
    {
        private int trackingNumber;
        public RetrieveTechnicalSupportEnquiryRequest setTechnicalSupportEnquiryTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getTechnicalSupportEnquiryTrackingNumber()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class RetrieveTechnicalSupportEnquiryResponse
    {
        private TechnicalSupportEnquiry technicalSupportEnquiry;
        private string error;
        public RetrieveTechnicalSupportEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveTechnicalSupportEnquiryResponse setTechnicalSupportEnquiry(TechnicalSupportEnquiry technicalSupportEnquiry)
        {
            this.technicalSupportEnquiry = technicalSupportEnquiry;
            return this;
        }
        public TechnicalSupportEnquiry getTechnicalSupportEnquiry()
        {
            return this.technicalSupportEnquiry;
        }
    }
    [Serializable]
    public class UpdateTechnicalSupportEnquiryRequest
    {
        private int trackingNumber;
        private TechnicalSupportEnquiry technicalSupportEnquiry;
        public UpdateTechnicalSupportEnquiryRequest setTechnicalSupportEnquiry(TechnicalSupportEnquiry technicalSupportEnquiry)
        {
            this.technicalSupportEnquiry = technicalSupportEnquiry;
            return this;
        }
        public TechnicalSupportEnquiry getTechnicalSupportEnquiry()
        {
            return this.technicalSupportEnquiry;
        }
        public UpdateTechnicalSupportEnquiryRequest setTechnicalSupportEnquiryTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getTechnicalSupportEnquiryTrackingNumberentifier()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class UpdateTechnicalSupportEnquiryResponse
    {
        private TechnicalSupportEnquiry technicalSupportEnquiry;
        private string error;
        public UpdateTechnicalSupportEnquiryResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateTechnicalSupportEnquiryResponse setTechnicalSupportEnquiry(TechnicalSupportEnquiry technicalSupportEnquiry)
        {
            this.technicalSupportEnquiry = technicalSupportEnquiry;
            return this;
        }
        public TechnicalSupportEnquiry getTechnicalSupportEnquiry()
        {
            return this.technicalSupportEnquiry;
        }
    }
    [Serializable]
    public class TechnicalSupportEnquiryNotUnique : Exception
    {
        public TechnicalSupportEnquiryNotUnique()
          : base()
        {
        }
        public TechnicalSupportEnquiryNotUnique(String message)
          : base(message)
        {
        }
        public TechnicalSupportEnquiryNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportEnquiryNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalSupportEnquiryAlreadyExists : Exception
    {
        public TechnicalSupportEnquiryAlreadyExists()
          : base()
        {
        }
        public TechnicalSupportEnquiryAlreadyExists(String message)
          : base(message)
        {
        }
        public TechnicalSupportEnquiryAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportEnquiryAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalSupportEnquiryDoesNotExist : Exception
    {
        public TechnicalSupportEnquiryDoesNotExist()
          : base()
        {
        }
        public TechnicalSupportEnquiryDoesNotExist(String message)
          : base(message)
        {
        }
        public TechnicalSupportEnquiryDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportEnquiryDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
