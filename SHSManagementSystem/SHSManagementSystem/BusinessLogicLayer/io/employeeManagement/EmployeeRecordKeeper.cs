using BusinessLayer.io.employeeManagement;
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

namespace BusinessLogicLayer.io.employeeManagement
{
    public class EmployeeRecordKeeper : IEmployeeRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public EmployeeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateEmployeeResponse CreateEmployee(CreateEmployeeRequest createEmployeeRequest)
        {
            try
            {
                if (createEmployeeRequest.getEmployee() == null)
                {
                    throw new RequestNotValid("CreateEmployeeRequest Not Valid.");
                }
                Employee exceptionTest = RetrieveEmployee(new RetrieveEmployeeRequest().setEmployeeId(
                    createEmployeeRequest.getEmployee().ID)).getEmployee();

                if (exceptionTest != null)
                {
                    throw new EmployeeAlreadyExists("EmployeeAlreadyExists");
                }
                unitOfWork.Employees.Add(createEmployeeRequest.getEmployee());
                unitOfWork.Complete();
            }
            catch (EmployeeAlreadyExists e)
            {
                return new CreateEmployeeResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateEmployeeResponse();
        }

        public FindEmployeeResponse FindEmployee(FindEmployeeRequest findEmployeeRequest)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                if (findEmployeeRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateEmployeeRequest Not Valid.");
                }

                if (findEmployeeRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<Employee, object>>> employeeIncluders = new List<Expression<Func<Employee, object>>>();
                    employeeIncluders.Add(x => x.Address);
                    employeeIncluders.Add(x => x.ContactInformation);
                    employeeIncluders.Add(x => x.LoginDetails);
                    //employeeIncluders.Add(x => x.BillingInformation);
                    //employeeIncluders.Add(x => x.ProductConfiguration);

                    employees = unitOfWork.Employees.GetAll(employeeIncluders) as List<Employee>;
                }
                // TODO if needed ; Search employees by certain criteria's.
                //else if (findEmployeeRequest.getSearchCriteria() is EmployeeSearchCriteria)
                //{
                //    EmployeeSearchCriteria searchCriterion = (EmployeeSearchCriteria)findEmployeeRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (employees == null)
                {
                    throw new EmployeeDoesNotExist("EmployeeDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindEmployeeResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (EmployeeDoesNotExist e)
            {
                return new FindEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindEmployeeResponse().setEmployee(employees);
        }

        public RemoveEmployeeResponse RemoveEmployee(RemoveEmployeeRequest removeEmployeeRequest)
        {
            try
            {
                if (removeEmployeeRequest.getEmployee() == null)
                {
                    throw new RequestNotValid("RemoveEmployeeRequest Not Valid.");
                }
                Employee exceptionTest = RetrieveEmployee(new RetrieveEmployeeRequest().setEmployeeId(
                                         removeEmployeeRequest.getEmployee().ID)).getEmployee();

                if (exceptionTest == null)
                {
                    throw new EmployeeDoesNotExist("EmployeeDoesNotExist");
                }
                unitOfWork.Employees.Remove(removeEmployeeRequest.getEmployee());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (EmployeeDoesNotExist e)
            {
                return new RemoveEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveEmployeeResponse();
        }

        public RetrieveEmployeeResponse RetrieveEmployee(RetrieveEmployeeRequest retrieveEmployeeRequest)
        {
            Employee employee = null;
            try
            {
                if (retrieveEmployeeRequest.getEmployeeId() == null)
                {
                    throw new RequestNotValid("RetrieveEmployeeRequest Not Valid.");
                }
                List<Expression<Func<Employee, object>>> employeeIncluders = new List<Expression<Func<Employee, object>>>();
                employeeIncluders.Add(x => x.Address);
                employeeIncluders.Add(x => x.ContactInformation);
                employeeIncluders.Add(x => x.LoginDetails);
                //employeeIncluders.Add(x => x.BillingInformation);
                //employeeIncluders.Add(x => x.ProductConfiguration);
                employee = unitOfWork.Employees.Get(retrieveEmployeeRequest.getEmployeeId(), employeeIncluders);

                if (employee == null)
                {
                    throw new EmployeeDoesNotExist("EmployeeDoesNotExist");
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
            catch (EmployeeDoesNotExist e)
            {
                return new RetrieveEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveEmployeeResponse().setEmployee(employee);
        }

        public UpdateEmployeeResponse UpdateEmployee(UpdateEmployeeRequest updateEmployeeRequest)
        {
            Employee employee = null;
            try
            {
                if (updateEmployeeRequest.getEmployee() == null)
                {
                    throw new RequestNotValid("UpdateEmployeeRequest Not Valid.");
                }

                employee = RetrieveEmployee(new RetrieveEmployeeRequest().setEmployeeId(
                                         updateEmployeeRequest.getEmployee().ID)).getEmployee();

                if (employee == null)
                {
                    throw new EmployeeDoesNotExist("EmployeeDoesNotExist");
                }

                employee = updateEmployeeRequest.getEmployee();
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
            catch (EmployeeDoesNotExist e)
            {
                return new UpdateEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateEmployeeResponse().setEmployee(employee);
        }
    }
}
