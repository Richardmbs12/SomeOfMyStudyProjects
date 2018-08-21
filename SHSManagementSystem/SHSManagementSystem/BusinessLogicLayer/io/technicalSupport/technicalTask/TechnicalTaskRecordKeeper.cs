using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.search.criteria;
using BusinessLayer.io.technicalSupport.technicalTask;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.technicalSupport.technicalTask
{
    public class TechnicalTaskRecordKeeper : ITechnicalTaskRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public TechnicalTaskRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateTechnicalTaskResponse CreateTechnicalTask(CreateTechnicalTaskRequest createTechnicalTaskRequest)
        {
            try
            {
                if (createTechnicalTaskRequest.getTechnicalTask() == null)
                {
                    throw new RequestNotValid("CreateTechnicalTaskRequest Not Valid.");
                }
                TechnicalTask exceptionTest = RetrieveTechnicalTask(new RetrieveTechnicalTaskRequest().setTechnicalTaskTrackingNumber(
                    createTechnicalTaskRequest.getTechnicalTask().TrackingNumber)).getTechnicalTask();

                if (exceptionTest != null)
                {
                    throw new TechnicalTaskAlreadyExists("TechnicalTaskAlreadyExists");
                }
                unitOfWork.TechnicalTasks.Add(createTechnicalTaskRequest.getTechnicalTask());
                unitOfWork.Complete();
            }
            catch (TechnicalTaskAlreadyExists e)
            {
                return new CreateTechnicalTaskResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateTechnicalTaskResponse();
        }

        public FindTechnicalTaskResponse FindTechnicalTask(FindTechnicalTaskRequest findTechnicalTaskRequest)
        {
            List<TechnicalTask> technicalTasks = new List<TechnicalTask>();
            try
            {
                if (findTechnicalTaskRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateTechnicalTaskRequest Not Valid.");
                }

                if (findTechnicalTaskRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<TechnicalTask, object>>> technicalTaskIncluders = new List<Expression<Func<TechnicalTask, object>>>();
                    technicalTaskIncluders.Add(x => x.CustomerEnquiry);
                    technicalTaskIncluders.Add(x => x.CustomerEnquiry.Customer);
                    technicalTaskIncluders.Add(x => x.CustomerEnquiry.Customer.Address);

                    technicalTasks = unitOfWork.TechnicalTasks.GetAll(technicalTaskIncluders) as List<TechnicalTask>;
                }
                // TODO if needed ; Search technicalTasks by certain criteria's.
                //else if (findTechnicalTaskRequest.getSearchCriteria() is TechnicalTaskSearchCriteria)
                //{
                //    TechnicalTaskSearchCriteria searchCriterion = (TechnicalTaskSearchCriteria)findTechnicalTaskRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchTrackingNumberentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (technicalTasks == null)
                {
                    throw new TechnicalTaskDoesNotExist("TechnicalTaskDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindTechnicalTaskResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalTaskDoesNotExist e)
            {
                return new FindTechnicalTaskResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindTechnicalTaskResponse().setTechnicalTask(technicalTasks);
        }

        public RemoveTechnicalTaskResponse RemoveTechnicalTask(RemoveTechnicalTaskRequest removeTechnicalTaskRequest)
        {
            try
            {
                if (removeTechnicalTaskRequest.getTechnicalTask() == null)
                {
                    throw new RequestNotValid("RemoveTechnicalTaskRequest Not Valid.");
                }
                TechnicalTask exceptionTest = RetrieveTechnicalTask(new RetrieveTechnicalTaskRequest().setTechnicalTaskTrackingNumber(
                                         removeTechnicalTaskRequest.getTechnicalTask().TrackingNumber)).getTechnicalTask();

                if (exceptionTest == null)
                {
                    throw new TechnicalTaskDoesNotExist("TechnicalTaskDoesNotExist");
                }
                unitOfWork.TechnicalTasks.Remove(removeTechnicalTaskRequest.getTechnicalTask());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalTaskDoesNotExist e)
            {
                return new RemoveTechnicalTaskResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveTechnicalTaskResponse();
        }

        public RetrieveTechnicalTaskResponse RetrieveTechnicalTask(RetrieveTechnicalTaskRequest retrieveTechnicalTaskRequest)
        {
            TechnicalTask technicalTask = null;
            try
            {
                if (retrieveTechnicalTaskRequest.getTechnicalTaskTrackingNumber() == null)
                {
                    throw new RequestNotValid("RetrieveTechnicalTaskRequest Not Valid.");
                }
                List<Expression<Func<TechnicalTask, object>>> technicalTaskIncluders = new List<Expression<Func<TechnicalTask, object>>>();
                technicalTaskIncluders.Add(x => x.CustomerEnquiry);
                technicalTaskIncluders.Add(x => x.CustomerEnquiry.Customer);
                technicalTaskIncluders.Add(x => x.CustomerEnquiry.Customer.Address);


                technicalTask = unitOfWork.TechnicalTasks.Get(retrieveTechnicalTaskRequest.getTechnicalTaskTrackingNumber(), technicalTaskIncluders);

                if (technicalTask == null)
                {
                    throw new TechnicalTaskDoesNotExist("TechnicalTaskDoesNotExist");
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
            catch (TechnicalTaskDoesNotExist e)
            {
                return new RetrieveTechnicalTaskResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveTechnicalTaskResponse().setTechnicalTask(technicalTask);
        }

        public UpdateTechnicalTaskResponse UpdateTechnicalTask(UpdateTechnicalTaskRequest updateTechnicalTaskRequest)
        {
            TechnicalTask technicalTask = null;
            try
            {
                if (updateTechnicalTaskRequest.getTechnicalTask() == null)
                {
                    throw new RequestNotValid("UpdateTechnicalTaskRequest Not Valid.");
                }

                technicalTask = RetrieveTechnicalTask(new RetrieveTechnicalTaskRequest().setTechnicalTaskTrackingNumber(
                                         updateTechnicalTaskRequest.getTechnicalTask().TrackingNumber)).getTechnicalTask();

                if (technicalTask == null)
                {
                    throw new TechnicalTaskDoesNotExist("TechnicalTaskDoesNotExist");
                }

                technicalTask = updateTechnicalTaskRequest.getTechnicalTask();
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
            catch (TechnicalTaskDoesNotExist e)
            {
                return new UpdateTechnicalTaskResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateTechnicalTaskResponse().setTechnicalTask(technicalTask);
        }
    }
}
