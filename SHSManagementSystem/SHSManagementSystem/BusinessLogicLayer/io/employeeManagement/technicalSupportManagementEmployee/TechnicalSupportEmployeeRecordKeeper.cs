using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.technicalSupportManagementEmployeeManagement.technicalSupportManagementTechnicalSupportManagementEmployee
{
    public class TechnicalSupportManagementEmployeeRecordKeeper : ITechnicalSupportManagementEmployeeRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public TechnicalSupportManagementEmployeeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateTechnicalSupportManagementEmployeeResponse CreateTechnicalSupportManagementEmployee(CreateTechnicalSupportManagementEmployeeRequest createTechnicalSupportManagementEmployeeRequest)
        {
            try
            {
                if (createTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee() == null)
                {
                    throw new RequestNotValid("CreateTechnicalSupportManagementEmployeeRequest Not Valid.");
                }
                TechnicalSupportManagementEmployee exceptionTest = RetrieveTechnicalSupportManagementEmployee(new RetrieveTechnicalSupportManagementEmployeeRequest().setTechnicalSupportManagementEmployeeId(
                    createTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee().ID)).getTechnicalSupportManagementEmployee();

                if (exceptionTest != null)
                {
                    throw new TechnicalSupportManagementEmployeeAlreadyExists("TechnicalSupportManagementEmployeeAlreadyExists");
                }
                unitOfWork.TechnicalSupportManagementEmployees.Add(createTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee());
                unitOfWork.Complete();
            }
            catch (TechnicalSupportManagementEmployeeAlreadyExists e)
            {
                return new CreateTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateTechnicalSupportManagementEmployeeResponse();
        }

        public FindTechnicalSupportManagementEmployeeResponse FindTechnicalSupportManagementEmployee(FindTechnicalSupportManagementEmployeeRequest findTechnicalSupportManagementEmployeeRequest)
        {
            List<TechnicalSupportManagementEmployee> technicalSupportManagementEmployees = new List<TechnicalSupportManagementEmployee>();
            try
            {
                if (findTechnicalSupportManagementEmployeeRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateTechnicalSupportManagementEmployeeRequest Not Valid.");
                }

                if (findTechnicalSupportManagementEmployeeRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<TechnicalSupportManagementEmployee, object>>> technicalSupportManagementEmployeeIncluders = new List<Expression<Func<TechnicalSupportManagementEmployee, object>>>();
                    technicalSupportManagementEmployeeIncluders.Add(x => x.Address);
                    technicalSupportManagementEmployeeIncluders.Add(x => x.ContactInformation);
                    technicalSupportManagementEmployeeIncluders.Add(x => x.LoginDetails);
                    //technicalSupportManagementEmployeeIncluders.Add(x => x.BillingInformation);
                    //technicalSupportManagementEmployeeIncluders.Add(x => x.ProductConfiguration);

                    technicalSupportManagementEmployees = unitOfWork.TechnicalSupportManagementEmployees.GetAll(technicalSupportManagementEmployeeIncluders) as List<TechnicalSupportManagementEmployee>;
                }
                // TODO if needed ; Search technicalSupportManagementEmployees by certain criteria's.
                //else if (findTechnicalSupportManagementEmployeeRequest.getSearchCriteria() is TechnicalSupportManagementEmployeeSearchCriteria)
                //{
                //    TechnicalSupportManagementEmployeeSearchCriteria searchCriterion = (TechnicalSupportManagementEmployeeSearchCriteria)findTechnicalSupportManagementEmployeeRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (technicalSupportManagementEmployees == null)
                {
                    throw new TechnicalSupportManagementEmployeeDoesNotExist("TechnicalSupportManagementEmployeeDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalSupportManagementEmployeeDoesNotExist e)
            {
                return new FindTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindTechnicalSupportManagementEmployeeResponse().setTechnicalSupportManagementEmployee(technicalSupportManagementEmployees);
        }

        public RemoveTechnicalSupportManagementEmployeeResponse RemoveTechnicalSupportManagementEmployee(RemoveTechnicalSupportManagementEmployeeRequest removeTechnicalSupportManagementEmployeeRequest)
        {
            try
            {
                if (removeTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee() == null)
                {
                    throw new RequestNotValid("RemoveTechnicalSupportManagementEmployeeRequest Not Valid.");
                }
                TechnicalSupportManagementEmployee exceptionTest = RetrieveTechnicalSupportManagementEmployee(new RetrieveTechnicalSupportManagementEmployeeRequest().setTechnicalSupportManagementEmployeeId(
                                         removeTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee().ID)).getTechnicalSupportManagementEmployee();

                if (exceptionTest == null)
                {
                    throw new TechnicalSupportManagementEmployeeDoesNotExist("TechnicalSupportManagementEmployeeDoesNotExist");
                }
                unitOfWork.TechnicalSupportManagementEmployees.Remove(removeTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalSupportManagementEmployeeDoesNotExist e)
            {
                return new RemoveTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveTechnicalSupportManagementEmployeeResponse();
        }

        public RetrieveTechnicalSupportManagementEmployeeResponse RetrieveTechnicalSupportManagementEmployee(RetrieveTechnicalSupportManagementEmployeeRequest retrieveTechnicalSupportManagementEmployeeRequest)
        {
            TechnicalSupportManagementEmployee technicalSupportManagementEmployee = null;
            try
            {
                if (retrieveTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployeeId() == null)
                {
                    throw new RequestNotValid("RetrieveTechnicalSupportManagementEmployeeRequest Not Valid.");
                }
                List<Expression<Func<TechnicalSupportManagementEmployee, object>>> technicalSupportManagementEmployeeIncluders = new List<Expression<Func<TechnicalSupportManagementEmployee, object>>>();
                technicalSupportManagementEmployeeIncluders.Add(x => x.Address);
                technicalSupportManagementEmployeeIncluders.Add(x => x.ContactInformation);
                technicalSupportManagementEmployeeIncluders.Add(x => x.LoginDetails);
                //technicalSupportManagementEmployeeIncluders.Add(x => x.BillingInformation);
                //technicalSupportManagementEmployeeIncluders.Add(x => x.ProductConfiguration);
                technicalSupportManagementEmployee = unitOfWork.TechnicalSupportManagementEmployees.Get(retrieveTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployeeId(), technicalSupportManagementEmployeeIncluders);

                if (technicalSupportManagementEmployee == null)
                {
                    throw new TechnicalSupportManagementEmployeeDoesNotExist("TechnicalSupportManagementEmployeeDoesNotExist");
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
            catch (TechnicalSupportManagementEmployeeDoesNotExist e)
            {
                return new RetrieveTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveTechnicalSupportManagementEmployeeResponse().setTechnicalSupportManagementEmployee(technicalSupportManagementEmployee);
        }

        public UpdateTechnicalSupportManagementEmployeeResponse UpdateTechnicalSupportManagementEmployee(UpdateTechnicalSupportManagementEmployeeRequest updateTechnicalSupportManagementEmployeeRequest)
        {
            TechnicalSupportManagementEmployee technicalSupportManagementEmployee = null;
            try
            {
                if (updateTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee() == null)
                {
                    throw new RequestNotValid("UpdateTechnicalSupportManagementEmployeeRequest Not Valid.");
                }

                technicalSupportManagementEmployee = RetrieveTechnicalSupportManagementEmployee(new RetrieveTechnicalSupportManagementEmployeeRequest().setTechnicalSupportManagementEmployeeId(
                                         updateTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee().ID)).getTechnicalSupportManagementEmployee();

                if (technicalSupportManagementEmployee == null)
                {
                    throw new TechnicalSupportManagementEmployeeDoesNotExist("TechnicalSupportManagementEmployeeDoesNotExist");
                }

                technicalSupportManagementEmployee = updateTechnicalSupportManagementEmployeeRequest.getTechnicalSupportManagementEmployee();
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
            catch (TechnicalSupportManagementEmployeeDoesNotExist e)
            {
                return new UpdateTechnicalSupportManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateTechnicalSupportManagementEmployeeResponse().setTechnicalSupportManagementEmployee(technicalSupportManagementEmployee);
        }
    }
}
