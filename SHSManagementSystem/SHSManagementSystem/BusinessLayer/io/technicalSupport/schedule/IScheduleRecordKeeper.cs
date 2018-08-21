using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.technicalSupport.schedule
{
    public interface IScheduleRecordKeeper
    {
        CreateScheduleResponse CreateSchedule(CreateScheduleRequest createScheduleRequest);
        FindScheduleResponse FindSchedule(FindScheduleRequest findScheduleRequest);
        RemoveScheduleResponse RemoveSchedule(RemoveScheduleRequest removeScheduleRequest);
        RetrieveScheduleResponse RetrieveSchedule(RetrieveScheduleRequest retrieveScheduleRequest);
        UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest updateScheduleRequest);
    }

    [Serializable]
    public class CreateScheduleRequest
    {
        private Schedule schedule;
        public CreateScheduleRequest setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
            return this;
        }
        public Schedule getSchedule()
        {
            return this.schedule;
        }
    }
    [Serializable]
    public class CreateScheduleResponse
    {
        private string error;
        public CreateScheduleResponse setError(string error)
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
    public class FindScheduleRequest
    {
        private SearchCriteria searchCriteria;
        public FindScheduleRequest setSearchCriteria(SearchCriteria searchCriteria)
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
    public class FindScheduleResponse
    {
        private List<Schedule> schedules;
        private string error;
        public FindScheduleResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindScheduleResponse setSchedule(List<Schedule> schedules)
        {
            this.schedules = schedules;
            return this;
        }
        public List<Schedule> getSchedules()
        {
            return this.schedules;
        }
    }
    [Serializable]
    public class RemoveScheduleRequest
    {
        private Schedule schedule;
        public RemoveScheduleRequest setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
            return this;
        }
        public Schedule getSchedule()
        {
            return this.schedule;
        }
    }
    [Serializable]
    public class RemoveScheduleResponse
    {
        private string error;
        public RemoveScheduleResponse setError(string error)
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
    public class RetrieveScheduleRequest
    {
        private int id;
        public RetrieveScheduleRequest setScheduleId(int id)
        {
            this.id = id;
            return this;
        }
        public int getScheduleId()
        {
            return this.id;
        }
    }
    [Serializable]
    public class RetrieveScheduleResponse
    {
        private Schedule schedule;
        private string error;
        public RetrieveScheduleResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveScheduleResponse setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
            return this;
        }
        public Schedule getSchedule()
        {
            return this.schedule;
        }
    }
    [Serializable]
    public class UpdateScheduleRequest
    {
        private int id;
        private Schedule schedule;
        public UpdateScheduleRequest setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
            return this;
        }
        public Schedule getSchedule()
        {
            return this.schedule;
        }
        public UpdateScheduleRequest setScheduleId(int id)
        {
            this.id = id;
            return this;
        }
        public int getScheduleIdentifier()
        {
            return this.id;
        }
    }
    [Serializable]
    public class UpdateScheduleResponse
    {
        private Schedule schedule;
        private string error;
        public UpdateScheduleResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateScheduleResponse setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
            return this;
        }
        public Schedule getSchedule()
        {
            return this.schedule;
        }
    }
    [Serializable]
    public class ScheduleNotUnique : Exception
    {
        public ScheduleNotUnique()
          : base()
        {
        }
        public ScheduleNotUnique(String message)
          : base(message)
        {
        }
        public ScheduleNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ScheduleNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ScheduleAlreadyExists : Exception
    {
        public ScheduleAlreadyExists()
          : base()
        {
        }
        public ScheduleAlreadyExists(String message)
          : base(message)
        {
        }
        public ScheduleAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ScheduleAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class ScheduleDoesNotExist : Exception
    {
        public ScheduleDoesNotExist()
          : base()
        {
        }
        public ScheduleDoesNotExist(String message)
          : base(message)
        {
        }
        public ScheduleDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected ScheduleDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
