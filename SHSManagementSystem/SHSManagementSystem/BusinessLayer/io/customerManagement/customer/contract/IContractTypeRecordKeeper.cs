using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.customerManagement.customer.contract
{
    public interface IContractTypeRecordKeeper
    {
        CreateContractTypeResponse CreateContractType(CreateContractTypeRequest createContractTypeRequest);
        FindContractTypeResponse FindContractType(FindContractTypeRequest findContractTypeRequest);
        RemoveContractTypeResponse RemoveContractType(RemoveContractTypeRequest removeContractTypeRequest);
        RetrieveContractTypeResponse RetrieveContractType(RetrieveContractTypeRequest retrieveContractTypeRequest);
        UpdateContractTypeResponse UpdateContractType(UpdateContractTypeRequest updateContractTypeRequest);
    }

    [Serializable]
    public class CreateContractTypeRequest
    {
        private ContractType contractType;
        public CreateContractTypeRequest setContractType(ContractType contractType)
        {
            this.contractType = contractType;
            return this;
        }
        public ContractType getContractType()
        {
            return this.contractType;
        }
    }
    [Serializable]
    public class CreateContractTypeResponse
    {
        private string error;
        public CreateContractTypeResponse setError(string error)
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
    public class FindContractTypeRequest
    {
        private SearchCriteria searchCriteria;
        public FindContractTypeRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindContractTypeResponse
    {
        private List<ContractType> contractTypes;
        private string error;
        public FindContractTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindContractTypeResponse setContractType(List<ContractType> contractTypes)
        {
            this.contractTypes = contractTypes;
            return this;
        }
        public List<ContractType> getContractTypes()
        {
            return this.contractTypes;
        }
    }
    [Serializable]
    public class RemoveContractTypeRequest
    {
        private ContractType contractType;
        public RemoveContractTypeRequest setContractType(ContractType contractType)
        {
            this.contractType = contractType;
            return this;
        }
        public ContractType getContractType()
        {
            return this.contractType;
        }
    }
    [Serializable]
    public class RemoveContractTypeResponse
    {
        private string error;
        public RemoveContractTypeResponse setError(string error)
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
    public class RetrieveContractTypeRequest
    {
        private string id;
        public RetrieveContractTypeRequest setContractTypeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getContractTypeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveContractTypeResponse
    {
        private ContractType contractType;
        private string error;
        public RetrieveContractTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveContractTypeResponse setContractType(ContractType contractType)
        {
            this.contractType = contractType;
            return this;
        }
        public ContractType getContractType()
        {
            return this.contractType;
        }
    }
    [Serializable]
    public class UpdateContractTypeRequest
    {
        private string id;
        private ContractType contractType;
        public UpdateContractTypeRequest setContractType(ContractType contractType)
        {
            this.contractType = contractType;
            return this;
        }
        public ContractType getContractType()
        {
            return this.contractType;
        }
        public UpdateContractTypeRequest setContractTypeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getContractTypeIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateContractTypeResponse
    {
        private ContractType contractType;
        private string error;
        public UpdateContractTypeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateContractTypeResponse setContractType(ContractType contractType)
        {
            this.contractType = contractType;
            return this;
        }
        public ContractType getContractType()
        {
            return this.contractType;
        }
    }
    [Serializable]
    public class ContractTypeNotUnique : Exception
    {
        public ContractTypeNotUnique()
          : base()
        {
        }
        public ContractTypeNotUnique(String message)
          : base(message)
        {
        }
        public ContractTypeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ContractTypeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ContractTypeAlreadyExists : Exception
    {
        public ContractTypeAlreadyExists()
          : base()
        {
        }
        public ContractTypeAlreadyExists(String message)
          : base(message)
        {
        }
        public ContractTypeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ContractTypeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ContractTypeDoesNotExist : Exception
    {
        public ContractTypeDoesNotExist()
          : base()
        {
        }
        public ContractTypeDoesNotExist(String message)
          : base(message)
        {
        }
        public ContractTypeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ContractTypeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
