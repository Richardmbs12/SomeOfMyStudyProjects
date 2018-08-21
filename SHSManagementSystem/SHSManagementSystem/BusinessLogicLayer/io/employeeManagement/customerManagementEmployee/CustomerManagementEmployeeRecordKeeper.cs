using BusinessLayer.io.customerManagementEmployeeManagement.customerManagementCustomerManagementEmployee;
using BusinessLayer.io.employeeManagement.customerManagementEmployee;
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

namespace BusinessLogicLayer.io.customerManagementEmployeeManagement.customerManagementCustomerManagementEmployee
{
    public class CustomerManagementEmployeeRecordKeeper : ICustomerManagementEmployeeRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public CustomerManagementEmployeeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateCustomerManagementEmployeeResponse CreateCustomerManagementEmployee(CreateCustomerManagementEmployeeRequest createCustomerManagementEmployeeRequest)
        {
            try
            {
                if (createCustomerManagementEmployeeRequest.getCustomerManagementEmployee() == null)
                {
                    throw new RequestNotValid("CreateCustomerManagementEmployeeRequest Not Valid.");
                }
                CustomerManagementEmployee exceptionTest = RetrieveCustomerManagementEmployee(new RetrieveCustomerManagementEmployeeRequest().setCustomerManagementEmployeeId(
                    createCustomerManagementEmployeeRequest.getCustomerManagementEmployee().ID)).getCustomerManagementEmployee();

                if (exceptionTest != null)
                {
                    throw new CustomerManagementEmployeeAlreadyExists("CustomerManagementEmployeeAlreadyExists");
                }
                unitOfWork.CustomerManagementEmployees.Add(createCustomerManagementEmployeeRequest.getCustomerManagementEmployee());
                unitOfWork.Complete();
            }
            catch (CustomerManagementEmployeeAlreadyExists e)
            {
                return new CreateCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateCustomerManagementEmployeeResponse();
        }

        public FindCustomerManagementEmployeeResponse FindCustomerManagementEmployee(FindCustomerManagementEmployeeRequest findCustomerManagementEmployeeRequest)
        {
            List<CustomerManagementEmployee> customerManagementEmployees = new List<CustomerManagementEmployee>();
            try
            {
                if (findCustomerManagementEmployeeRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateCustomerManagementEmployeeRequest Not Valid.");
                }

                if (findCustomerManagementEmployeeRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<CustomerManagementEmployee, object>>> customerManagementEmployeeIncluders = new List<Expression<Func<CustomerManagementEmployee, object>>>();
                    customerManagementEmployeeIncluders.Add(x => x.Address);
                    customerManagementEmployeeIncluders.Add(x => x.ContactInformation);
                    customerManagementEmployeeIncluders.Add(x => x.LoginDetails);
                    //customerManagementEmployeeIncluders.Add(x => x.BillingInformation);
                    //customerManagementEmployeeIncluders.Add(x => x.ProductConfiguration);

                    customerManagementEmployees = unitOfWork.CustomerManagementEmployees.GetAll(customerManagementEmployeeIncluders) as List<CustomerManagementEmployee>;
                }
                // TODO if needed ; Search customerManagementEmployees by certain criteria's.
                //else if (findCustomerManagementEmployeeRequest.getSearchCriteria() is CustomerManagementEmployeeSearchCriteria)
                //{
                //    CustomerManagementEmployeeSearchCriteria searchCriterion = (CustomerManagementEmployeeSearchCriteria)findCustomerManagementEmployeeRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (customerManagementEmployees == null)
                {
                    throw new CustomerManagementEmployeeDoesNotExist("CustomerManagementEmployeeDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerManagementEmployeeDoesNotExist e)
            {
                return new FindCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindCustomerManagementEmployeeResponse().setCustomerManagementEmployee(customerManagementEmployees);
        }

        public RemoveCustomerManagementEmployeeResponse RemoveCustomerManagementEmployee(RemoveCustomerManagementEmployeeRequest removeCustomerManagementEmployeeRequest)
        {
            try
            {
                if (removeCustomerManagementEmployeeRequest.getCustomerManagementEmployee() == null)
                {
                    throw new RequestNotValid("RemoveCustomerManagementEmployeeRequest Not Valid.");
                }
                CustomerManagementEmployee exceptionTest = RetrieveCustomerManagementEmployee(new RetrieveCustomerManagementEmployeeRequest().setCustomerManagementEmployeeId(
                                         removeCustomerManagementEmployeeRequest.getCustomerManagementEmployee().ID)).getCustomerManagementEmployee();

                if (exceptionTest == null)
                {
                    throw new CustomerManagementEmployeeDoesNotExist("CustomerManagementEmployeeDoesNotExist");
                }
                unitOfWork.CustomerManagementEmployees.Remove(removeCustomerManagementEmployeeRequest.getCustomerManagementEmployee());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerManagementEmployeeDoesNotExist e)
            {
                return new RemoveCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveCustomerManagementEmployeeResponse();
        }

        public RetrieveCustomerManagementEmployeeResponse RetrieveCustomerManagementEmployee(RetrieveCustomerManagementEmployeeRequest retrieveCustomerManagementEmployeeRequest)
        {
            CustomerManagementEmployee customerManagementEmployee = null;
            try
            {
                if (retrieveCustomerManagementEmployeeRequest.getCustomerManagementEmployeeId() == null)
                {
                    throw new RequestNotValid("RetrieveCustomerManagementEmployeeRequest Not Valid.");
                }
                List<Expression<Func<CustomerManagementEmployee, object>>> customerManagementEmployeeIncluders = new List<Expression<Func<CustomerManagementEmployee, object>>>();
                customerManagementEmployeeIncluders.Add(x => x.Address);
                customerManagementEmployeeIncluders.Add(x => x.ContactInformation);
                customerManagementEmployeeIncluders.Add(x => x.LoginDetails);
                //customerManagementEmployeeIncluders.Add(x => x.BillingInformation);
                //customerManagementEmployeeIncluders.Add(x => x.ProductConfiguration);
                customerManagementEmployee = unitOfWork.CustomerManagementEmployees.Get(retrieveCustomerManagementEmployeeRequest.getCustomerManagementEmployeeId(), customerManagementEmployeeIncluders);

                if (customerManagementEmployee == null)
                {
                    throw new CustomerManagementEmployeeDoesNotExist("CustomerManagementEmployeeDoesNotExist");
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
            catch (CustomerManagementEmployeeDoesNotExist e)
            {
                return new RetrieveCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveCustomerManagementEmployeeResponse().setCustomerManagementEmployee(customerManagementEmployee);
        }

        public UpdateCustomerManagementEmployeeResponse UpdateCustomerManagementEmployee(UpdateCustomerManagementEmployeeRequest updateCustomerManagementEmployeeRequest)
        {
            CustomerManagementEmployee customerManagementEmployee = null;
            try
            {
                if (updateCustomerManagementEmployeeRequest.getCustomerManagementEmployee() == null)
                {
                    throw new RequestNotValid("UpdateCustomerManagementEmployeeRequest Not Valid.");
                }

                customerManagementEmployee = RetrieveCustomerManagementEmployee(new RetrieveCustomerManagementEmployeeRequest().setCustomerManagementEmployeeId(
                                         updateCustomerManagementEmployeeRequest.getCustomerManagementEmployee().ID)).getCustomerManagementEmployee();

                if (customerManagementEmployee == null)
                {
                    throw new CustomerManagementEmployeeDoesNotExist("CustomerManagementEmployeeDoesNotExist");
                }

                customerManagementEmployee = updateCustomerManagementEmployeeRequest.getCustomerManagementEmployee();
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
            catch (CustomerManagementEmployeeDoesNotExist e)
            {
                return new UpdateCustomerManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateCustomerManagementEmployeeResponse().setCustomerManagementEmployee(customerManagementEmployee);
        }
    }
}
