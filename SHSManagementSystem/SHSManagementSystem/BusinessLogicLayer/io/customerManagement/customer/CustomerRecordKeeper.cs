using BusinessLayer.io.customerManagement.customer;
using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLogicLayer.io.customerManagement.customer
{
    public class CustomerRecordKeeper : ICustomerRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public CustomerRecordKeeper(IUnitOfWork unitOfWork , IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest createCustomerRequest)
        {
            try
            {
                if (createCustomerRequest.getCustomer() == null)
                {
                    throw new RequestNotValid("CreateCustomerRequest Not Valid.");
                }
                Customer exceptionTest = RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(
                    createCustomerRequest.getCustomer().ID)).getCustomer();

                if (exceptionTest != null)
                {
                        throw new CustomerAlreadyExists("CustomerAlreadyExists");
                }
                unitOfWork.Customers.Add(createCustomerRequest.getCustomer());
                unitOfWork.Complete();
            }
            catch (CustomerAlreadyExists e)
            {
                return new CreateCustomerResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateCustomerResponse();
        }

        public FindCustomerResponse FindCustomer(FindCustomerRequest findCustomerRequest)
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                if (findCustomerRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateCustomerRequest Not Valid.");
                }

                if (findCustomerRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<Customer, object>>> customerIncluders = new List<Expression<Func<Customer, object>>>();
                    customerIncluders.Add(x => x.Address);
                    customerIncluders.Add(x => x.ContactInformation);
                    customerIncluders.Add(x => x.CustomerEnquiries);
                    customerIncluders.Add(x => x.BillingInformation);
                    customerIncluders.Add(x => x.BillingInformation.BillingHistory);
                    customerIncluders.Add(x => x.ProductConfiguration);
                    customerIncluders.Add(x => x.ProductConfiguration.InstalledProducts);
                    customerIncluders.Add(x => x.Contract);
                    customerIncluders.Add(x => x.Contract.ContractType);

                    customers = unitOfWork.Customers.GetAll(customerIncluders) as List<Customer>;
                }
                // TODO if needed ; Search customers by certain criteria's.
                //else if (findCustomerRequest.getSearchCriteria() is CustomerSearchCriteria)
                //{
                //    CustomerSearchCriteria searchCriterion = (CustomerSearchCriteria)findCustomerRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (customers == null)
                {
                    throw new CustomerDoesNotExist("CustomerDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindCustomerResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerDoesNotExist e)
            {
                return new FindCustomerResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindCustomerResponse().setCustomer(customers);
        }

        public RemoveCustomerResponse RemoveCustomer(RemoveCustomerRequest removeCustomerRequest)
        {
            try
            {
                if (removeCustomerRequest.getCustomer() == null)
                {
                    throw new RequestNotValid("RemoveCustomerRequest Not Valid.");
                }
                Customer customer = RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(
                                         removeCustomerRequest.getCustomer().ID)).getCustomer();

                if (customer == null)
                {
                    throw new CustomerDoesNotExist("CustomerDoesNotExist");
                }

                unitOfWork.BillingInvoices.RemoveRange(customer.BillingInformation.BillingHistory);
                unitOfWork.Customers.Remove(removeCustomerRequest.getCustomer());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerDoesNotExist e)
            {
                return new RemoveCustomerResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveCustomerResponse();
        }

        public RetrieveCustomerResponse RetrieveCustomer(RetrieveCustomerRequest retrieveCustomerRequest)
        {
            Customer customer = null;
            try
            {
                if (retrieveCustomerRequest.getCustomerId() == null)
                {
                    throw new RequestNotValid("RetrieveCustomerRequest Not Valid.");
                }
                List<Expression<Func<Customer, object>>> customerIncluders = new List<Expression<Func<Customer, object>>>();
                customerIncluders.Add(x => x.Address);
                customerIncluders.Add(x => x.ContactInformation);
                customerIncluders.Add(x => x.CustomerEnquiries);
                customerIncluders.Add(x => x.BillingInformation);
                customerIncluders.Add(x => x.BillingInformation.BillingHistory);
                customerIncluders.Add(x => x.ProductConfiguration);
                customerIncluders.Add(x => x.ProductConfiguration.InstalledProducts);
                customerIncluders.Add(x => x.Contract);
                customerIncluders.Add(x => x.Contract.ContractType);

                customer = unitOfWork.Customers.Get(retrieveCustomerRequest.getCustomerId(), customerIncluders);

                if (customer == null)
                {
                    throw new CustomerDoesNotExist("CustomerDoesNotExist");
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
            catch (CustomerDoesNotExist e)
            {
                return new RetrieveCustomerResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveCustomerResponse().setCustomer(customer);
        }

        public UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest updateCustomerRequest)
        {
            Customer customer = null;
            try
            {
                if (updateCustomerRequest.getCustomer() == null)
                {
                    throw new RequestNotValid("UpdateCustomerRequest Not Valid.");
                }

                customer = RetrieveCustomer(new RetrieveCustomerRequest().setCustomerId(
                                         updateCustomerRequest.getCustomer().ID)).getCustomer();

                if (customer == null)
                {
                    throw new CustomerDoesNotExist("CustomerDoesNotExist");
                }

                customer = updateCustomerRequest.getCustomer();
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
            catch (CustomerDoesNotExist e)
            {
                return new UpdateCustomerResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateCustomerResponse().setCustomer(customer);
        }
    }
}
