using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee
{
    public interface ITechnicalSupportManagementEmployeeRecordKeeper
    {
        CreateTechnicalSupportManagementEmployeeResponse CreateTechnicalSupportManagementEmployee(CreateTechnicalSupportManagementEmployeeRequest createTechnicalSupportManagementEmployeeRequest);
        FindTechnicalSupportManagementEmployeeResponse FindTechnicalSupportManagementEmployee(FindTechnicalSupportManagementEmployeeRequest findTechnicalSupportManagementEmployeeRequest);
        RemoveTechnicalSupportManagementEmployeeResponse RemoveTechnicalSupportManagementEmployee(RemoveTechnicalSupportManagementEmployeeRequest removeTechnicalSupportManagementEmployeeRequest);
        RetrieveTechnicalSupportManagementEmployeeResponse RetrieveTechnicalSupportManagementEmployee(RetrieveTechnicalSupportManagementEmployeeRequest retrieveTechnicalSupportManagementEmployeeRequest);
        UpdateTechnicalSupportManagementEmployeeResponse UpdateTechnicalSupportManagementEmployee(UpdateTechnicalSupportManagementEmployeeRequest updateTechnicalSupportManagementEmployeeRequest);
    }

    [Serializable]
    public class CreateTechnicalSupportManagementEmployeeRequest
    {
        private TechnicalSupportManagementEmployee technicalSupportManagementEmployee;
        public CreateTechnicalSupportManagementEmployeeRequest setTechnicalSupportManagementEmployee(TechnicalSupportManagementEmployee technicalSupportManagementEmployee)
        {
            this.technicalSupportManagementEmployee = technicalSupportManagementEmployee;
            return this;
        }
        public TechnicalSupportManagementEmployee getTechnicalSupportManagementEmployee()
        {
            return this.technicalSupportManagementEmployee;
        }
    }
    [Serializable]
    public class CreateTechnicalSupportManagementEmployeeResponse
    {
        private string error;
        public CreateTechnicalSupportManagementEmployeeResponse setError(string error)
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
    public class FindTechnicalSupportManagementEmployeeRequest
    {
        private SearchCriteria searchCriteria;
        public FindTechnicalSupportManagementEmployeeRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindTechnicalSupportManagementEmployeeResponse
    {
        private List<TechnicalSupportManagementEmployee> technicalSupportManagementEmployees;
        private string error;
        public FindTechnicalSupportManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindTechnicalSupportManagementEmployeeResponse setTechnicalSupportManagementEmployee(List<TechnicalSupportManagementEmployee> technicalSupportManagementEmployees)
        {
            this.technicalSupportManagementEmployees = technicalSupportManagementEmployees;
            return this;
        }
        public List<TechnicalSupportManagementEmployee> getTechnicalSupportManagementEmployees()
        {
            return this.technicalSupportManagementEmployees;
        }
    }
    [Serializable]
    public class RemoveTechnicalSupportManagementEmployeeRequest
    {
        private TechnicalSupportManagementEmployee technicalSupportManagementEmployee;
        public RemoveTechnicalSupportManagementEmployeeRequest setTechnicalSupportManagementEmployee(TechnicalSupportManagementEmployee technicalSupportManagementEmployee)
        {
            this.technicalSupportManagementEmployee = technicalSupportManagementEmployee;
            return this;
        }
        public TechnicalSupportManagementEmployee getTechnicalSupportManagementEmployee()
        {
            return this.technicalSupportManagementEmployee;
        }
    }
    [Serializable]
    public class RemoveTechnicalSupportManagementEmployeeResponse
    {
        private string error;
        public RemoveTechnicalSupportManagementEmployeeResponse setError(string error)
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
    public class RetrieveTechnicalSupportManagementEmployeeRequest
    {
        private string id;
        public RetrieveTechnicalSupportManagementEmployeeRequest setTechnicalSupportManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getTechnicalSupportManagementEmployeeId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveTechnicalSupportManagementEmployeeResponse
    {
        private TechnicalSupportManagementEmployee technicalSupportManagementEmployee;
        private string error;
        public RetrieveTechnicalSupportManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveTechnicalSupportManagementEmployeeResponse setTechnicalSupportManagementEmployee(TechnicalSupportManagementEmployee technicalSupportManagementEmployee)
        {
            this.technicalSupportManagementEmployee = technicalSupportManagementEmployee;
            return this;
        }
        public TechnicalSupportManagementEmployee getTechnicalSupportManagementEmployee()
        {
            return this.technicalSupportManagementEmployee;
        }
    }
    [Serializable]
    public class UpdateTechnicalSupportManagementEmployeeRequest
    {
        private string id;
        private TechnicalSupportManagementEmployee technicalSupportManagementEmployee;
        public UpdateTechnicalSupportManagementEmployeeRequest setTechnicalSupportManagementEmployee(TechnicalSupportManagementEmployee technicalSupportManagementEmployee)
        {
            this.technicalSupportManagementEmployee = technicalSupportManagementEmployee;
            return this;
        }
        public TechnicalSupportManagementEmployee getTechnicalSupportManagementEmployee()
        {
            return this.technicalSupportManagementEmployee;
        }
        public UpdateTechnicalSupportManagementEmployeeRequest setTechnicalSupportManagementEmployeeId(string id)
        {
            this.id = id;
            return this;
        }
        public string getTechnicalSupportManagementEmployeeIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateTechnicalSupportManagementEmployeeResponse
    {
        private TechnicalSupportManagementEmployee technicalSupportManagementEmployee;
        private string error;
        public UpdateTechnicalSupportManagementEmployeeResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateTechnicalSupportManagementEmployeeResponse setTechnicalSupportManagementEmployee(TechnicalSupportManagementEmployee technicalSupportManagementEmployee)
        {
            this.technicalSupportManagementEmployee = technicalSupportManagementEmployee;
            return this;
        }
        public TechnicalSupportManagementEmployee getTechnicalSupportManagementEmployee()
        {
            return this.technicalSupportManagementEmployee;
        }
    }
    [Serializable]
    public class TechnicalSupportManagementEmployeeNotUnique : Exception
    {
        public TechnicalSupportManagementEmployeeNotUnique()
          : base()
        {
        }
        public TechnicalSupportManagementEmployeeNotUnique(String message)
          : base(message)
        {
        }
        public TechnicalSupportManagementEmployeeNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportManagementEmployeeNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalSupportManagementEmployeeAlreadyExists : Exception
    {
        public TechnicalSupportManagementEmployeeAlreadyExists()
          : base()
        {
        }
        public TechnicalSupportManagementEmployeeAlreadyExists(String message)
          : base(message)
        {
        }
        public TechnicalSupportManagementEmployeeAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportManagementEmployeeAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalSupportManagementEmployeeDoesNotExist : Exception
    {
        public TechnicalSupportManagementEmployeeDoesNotExist()
          : base()
        {
        }
        public TechnicalSupportManagementEmployeeDoesNotExist(String message)
          : base(message)
        {
        }
        public TechnicalSupportManagementEmployeeDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalSupportManagementEmployeeDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
