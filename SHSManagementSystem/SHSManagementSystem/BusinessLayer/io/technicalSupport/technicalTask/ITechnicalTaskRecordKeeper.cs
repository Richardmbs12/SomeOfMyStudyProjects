using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.technicalSupport.technicalTask
{
    public interface ITechnicalTaskRecordKeeper
    {
        CreateTechnicalTaskResponse CreateTechnicalTask(CreateTechnicalTaskRequest createTechnicalTaskRequest);
        FindTechnicalTaskResponse FindTechnicalTask(FindTechnicalTaskRequest findTechnicalTaskRequest);
        RemoveTechnicalTaskResponse RemoveTechnicalTask(RemoveTechnicalTaskRequest removeTechnicalTaskRequest);
        RetrieveTechnicalTaskResponse RetrieveTechnicalTask(RetrieveTechnicalTaskRequest retrieveTechnicalTaskRequest);
        UpdateTechnicalTaskResponse UpdateTechnicalTask(UpdateTechnicalTaskRequest updateTechnicalTaskRequest);
    }

    [Serializable]
    public class CreateTechnicalTaskRequest
    {
        private TechnicalTask technicalTask;
        public CreateTechnicalTaskRequest setTechnicalTask(TechnicalTask technicalTask)
        {
            this.technicalTask = technicalTask;
            return this;
        }
        public TechnicalTask getTechnicalTask()
        {
            return this.technicalTask;
        }
    }
    [Serializable]
    public class CreateTechnicalTaskResponse
    {
        private string error;
        public CreateTechnicalTaskResponse setError(string error)
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
    public class FindTechnicalTaskRequest
    {
        private SearchCriteria searchCriteria;
        public FindTechnicalTaskRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindTechnicalTaskResponse
    {
        private List<TechnicalTask> technicalTasks;
        private string error;
        public FindTechnicalTaskResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindTechnicalTaskResponse setTechnicalTask(List<TechnicalTask> technicalTasks)
        {
            this.technicalTasks = technicalTasks;
            return this;
        }
        public List<TechnicalTask> getTechnicalTasks()
        {
            return this.technicalTasks;
        }
    }
    [Serializable]
    public class RemoveTechnicalTaskRequest
    {
        private TechnicalTask technicalTask;
        public RemoveTechnicalTaskRequest setTechnicalTask(TechnicalTask technicalTask)
        {
            this.technicalTask = technicalTask;
            return this;
        }
        public TechnicalTask getTechnicalTask()
        {
            return this.technicalTask;
        }
    }
    [Serializable]
    public class RemoveTechnicalTaskResponse
    {
        private string error;
        public RemoveTechnicalTaskResponse setError(string error)
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
    public class RetrieveTechnicalTaskRequest
    {
        private int trackingNumber;
        public RetrieveTechnicalTaskRequest setTechnicalTaskTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getTechnicalTaskTrackingNumber()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class RetrieveTechnicalTaskResponse
    {
        private TechnicalTask technicalTask;
        private string error;
        public RetrieveTechnicalTaskResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveTechnicalTaskResponse setTechnicalTask(TechnicalTask technicalTask)
        {
            this.technicalTask = technicalTask;
            return this;
        }
        public TechnicalTask getTechnicalTask()
        {
            return this.technicalTask;
        }
    }
    [Serializable]
    public class UpdateTechnicalTaskRequest
    {
        private int trackingNumber;
        private TechnicalTask technicalTask;
        public UpdateTechnicalTaskRequest setTechnicalTask(TechnicalTask technicalTask)
        {
            this.technicalTask = technicalTask;
            return this;
        }
        public TechnicalTask getTechnicalTask()
        {
            return this.technicalTask;
        }
        public UpdateTechnicalTaskRequest setTechnicalTaskTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getTechnicalTaskTrackingNumberentifier()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class UpdateTechnicalTaskResponse
    {
        private TechnicalTask technicalTask;
        private string error;
        public UpdateTechnicalTaskResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateTechnicalTaskResponse setTechnicalTask(TechnicalTask technicalTask)
        {
            this.technicalTask = technicalTask;
            return this;
        }
        public TechnicalTask getTechnicalTask()
        {
            return this.technicalTask;
        }
    }
    [Serializable]
    public class TechnicalTaskNotUnique : Exception
    {
        public TechnicalTaskNotUnique()
          : base()
        {
        }
        public TechnicalTaskNotUnique(String message)
          : base(message)
        {
        }
        public TechnicalTaskNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalTaskNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalTaskAlreadyExists : Exception
    {
        public TechnicalTaskAlreadyExists()
          : base()
        {
        }
        public TechnicalTaskAlreadyExists(String message)
          : base(message)
        {
        }
        public TechnicalTaskAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalTaskAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class TechnicalTaskDoesNotExist : Exception
    {
        public TechnicalTaskDoesNotExist()
          : base()
        {
        }
        public TechnicalTaskDoesNotExist(String message)
          : base(message)
        {
        }
        public TechnicalTaskDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected TechnicalTaskDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
