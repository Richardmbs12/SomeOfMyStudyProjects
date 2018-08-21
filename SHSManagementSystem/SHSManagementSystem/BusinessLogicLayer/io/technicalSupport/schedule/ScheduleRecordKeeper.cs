using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.technicalSupport.schedule;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.technicalSupport.schedule
{
    public class ScheduleRecordKeeper : IScheduleRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public ScheduleRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateScheduleResponse CreateSchedule(CreateScheduleRequest createScheduleRequest)
        {
            try
            {
                if (createScheduleRequest.getSchedule() == null)
                {
                    throw new RequestNotValid("CreateScheduleRequest Not Valid.");
                }
                Schedule exceptionTest = RetrieveSchedule(new RetrieveScheduleRequest().setScheduleId(
                    createScheduleRequest.getSchedule().ScheduleID)).getSchedule();

                if (exceptionTest != null)
                {
                    throw new ScheduleAlreadyExists("ScheduleAlreadyExists");
                }
                unitOfWork.Schedules.Add(createScheduleRequest.getSchedule());
                unitOfWork.Complete();
            }
            catch (ScheduleAlreadyExists e)
            {
                return new CreateScheduleResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateScheduleResponse();
        }

        public FindScheduleResponse FindSchedule(FindScheduleRequest findScheduleRequest)
        {
            List<Schedule> schedules = new List<Schedule>();
            try
            {
                if (findScheduleRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateScheduleRequest Not Valid.");
                }

                if (findScheduleRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<Schedule, object>>> scheduleIncluders = new List<Expression<Func<Schedule, object>>>();
                    scheduleIncluders.Add(x => x.TechnicalSupportEmployee);
                    scheduleIncluders.Add(x => x.Tasks);

                    schedules = unitOfWork.Schedules.GetAll(scheduleIncluders) as List<Schedule>;
                }
                // TODO if needed ; Search scheduleEnquiries by certain criteria's.
                //else if (findScheduleRequest.getSearchCriteria() is ScheduleSearchCriteria)
                //{
                //    ScheduleSearchCriteria searchCriterion = (ScheduleSearchCriteria)findScheduleRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIDentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (schedules == null)
                {
                    throw new ScheduleDoesNotExist("ScheduleDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindScheduleResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ScheduleDoesNotExist e)
            {
                return new FindScheduleResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindScheduleResponse().setSchedule(schedules);
        }

        public RemoveScheduleResponse RemoveSchedule(RemoveScheduleRequest removeScheduleRequest)
        {
            try
            {
                if (removeScheduleRequest.getSchedule() == null)
                {
                    throw new RequestNotValid("RemoveScheduleRequest Not Valid.");
                }
                Schedule exceptionTest = RetrieveSchedule(new RetrieveScheduleRequest().setScheduleId(
                                         removeScheduleRequest.getSchedule().ScheduleID)).getSchedule();

                if (exceptionTest == null)
                {
                    throw new ScheduleDoesNotExist("ScheduleDoesNotExist");
                }
                unitOfWork.Schedules.Remove(removeScheduleRequest.getSchedule());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ScheduleDoesNotExist e)
            {
                return new RemoveScheduleResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveScheduleResponse();
        }

        public RetrieveScheduleResponse RetrieveSchedule(RetrieveScheduleRequest retrieveScheduleRequest)
        {
            Schedule schedule = null;
            try
            {
                if (retrieveScheduleRequest.getScheduleId() == null)
                {
                    throw new RequestNotValid("RetrieveScheduleRequest Not Valid.");
                }
                List<Expression<Func<Schedule, object>>> scheduleIncluders = new List<Expression<Func<Schedule, object>>>();
                scheduleIncluders.Add(x => x.TechnicalSupportEmployee);
                scheduleIncluders.Add(x => x.Tasks);

                schedule = unitOfWork.Schedules.Get(retrieveScheduleRequest.getScheduleId(), scheduleIncluders);

                if (schedule == null)
                {
                    throw new ScheduleDoesNotExist("ScheduleDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ScheduleDoesNotExist e)
            {
                return new RetrieveScheduleResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveScheduleResponse().setSchedule(schedule);
        }

        public UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest updateScheduleRequest)
        {
            Schedule schedule = null;
            try
            {
                if (updateScheduleRequest.getSchedule() == null)
                {
                    throw new RequestNotValid("UpdateScheduleRequest Not Valid.");
                }

                schedule = RetrieveSchedule(new RetrieveScheduleRequest().setScheduleId(
                                         updateScheduleRequest.getSchedule().ScheduleID)).getSchedule();

                if (schedule == null)
                {
                    throw new ScheduleDoesNotExist("ScheduleDoesNotExist");
                }

                schedule = updateScheduleRequest.getSchedule();
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ScheduleDoesNotExist e)
            {
                return new UpdateScheduleResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateScheduleResponse().setSchedule(schedule);
        }
    }
}
