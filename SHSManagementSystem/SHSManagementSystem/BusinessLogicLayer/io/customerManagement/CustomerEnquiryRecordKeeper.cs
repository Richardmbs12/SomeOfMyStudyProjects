using BusinessLayer.io.customerEnquiryManagement.enquiries;
using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.orderManagement.enquiries.customerEnquiry.searchCriteria;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.customerEnquiryManagement
{
    public class CustomerEnquiryRecordKeeper : ICustomerEnquiryRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public CustomerEnquiryRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateCustomerEnquiryResponse CreateCustomerEnquiry(CreateCustomerEnquiryRequest createCustomerEnquiryRequest)
        {
            try
            {
                if (createCustomerEnquiryRequest.getCustomerEnquiry() == null)
                {
                    throw new RequestNotValid("CreateCustomerEnquiryRequest Not Valid.");
                }
                CustomerEnquiry exceptionTest = RetrieveCustomerEnquiry(new RetrieveCustomerEnquiryRequest().setCustomerEnquiryTrackingNumber(
                    createCustomerEnquiryRequest.getCustomerEnquiry().TrackingNumber)).getCustomerEnquiry();

                if (exceptionTest != null)
                {
                    throw new CustomerEnquiryAlreadyExists("CustomerEnquiryAlreadyExists");
                }
                unitOfWork.CustomerEnquiries.Add(createCustomerEnquiryRequest.getCustomerEnquiry());
                unitOfWork.Complete();
            }
            catch (CustomerEnquiryAlreadyExists e)
            {
                return new CreateCustomerEnquiryResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateCustomerEnquiryResponse();
        }

        public FindCustomerEnquiryResponse FindCustomerEnquiry(FindCustomerEnquiryRequest findCustomerEnquiryRequest)
        {
            List<CustomerEnquiry> customerEnquiries = new List<CustomerEnquiry>();
            try
            {
                if (findCustomerEnquiryRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateCustomerEnquiryRequest Not Valid.");
                }
                List<Expression<Func<CustomerEnquiry, object>>> customerEnquiryIncluders = new List<Expression<Func<CustomerEnquiry, object>>>();
                customerEnquiryIncluders.Add(x => x.Customer);
                customerEnquiryIncluders.Add(x => x.TechnicalTask);
                if (findCustomerEnquiryRequest.getSearchCriteria() is AllSearch)
                {
                    customerEnquiries = unitOfWork.CustomerEnquiries.GetAll(customerEnquiryIncluders) as List<CustomerEnquiry>;
                }
                else if (findCustomerEnquiryRequest.getSearchCriteria() is CustomerEnquirySearchCriteria)
                {
                    string id = ((CustomerEnquirySearchCriteria)findCustomerEnquiryRequest.getSearchCriteria()).getCustomerId();
                    customerEnquiries = unitOfWork.CustomerEnquiries.Find(x => x.Customer.ID == id, customerEnquiryIncluders) as List<CustomerEnquiry>;
                }
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (customerEnquiries.Count == 0)
                {
                    throw new CustomerEnquiryDoesNotExist("CustomerEnquiryDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindCustomerEnquiryResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerEnquiryDoesNotExist e)
            {
                return new FindCustomerEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindCustomerEnquiryResponse().setCustomerEnquiries(customerEnquiries);
        }

        public RemoveCustomerEnquiryResponse RemoveCustomerEnquiry(RemoveCustomerEnquiryRequest removeCustomerEnquiryRequest)
        {
            try
            {
                if (removeCustomerEnquiryRequest.getCustomerEnquiry() == null)
                {
                    throw new RequestNotValid("RemoveCustomerEnquiryRequest Not Valid.");
                }
                CustomerEnquiry exceptionTest = RetrieveCustomerEnquiry(new RetrieveCustomerEnquiryRequest().setCustomerEnquiryTrackingNumber(
                                         removeCustomerEnquiryRequest.getCustomerEnquiry().TrackingNumber)).getCustomerEnquiry();

                if (exceptionTest == null)
                {
                    throw new CustomerEnquiryDoesNotExist("CustomerEnquiryDoesNotExist");
                }
                unitOfWork.CustomerEnquiries.Remove(removeCustomerEnquiryRequest.getCustomerEnquiry());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (CustomerEnquiryDoesNotExist e)
            {
                return new RemoveCustomerEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveCustomerEnquiryResponse();
        }

        public RetrieveCustomerEnquiryResponse RetrieveCustomerEnquiry(RetrieveCustomerEnquiryRequest retrieveCustomerEnquiryRequest)
        {
            CustomerEnquiry customerEnquiry = null;
            try
            {
                if (retrieveCustomerEnquiryRequest.getCustomerEnquiryTrackingNumber() == null)
                {
                    throw new RequestNotValid("RetrieveCustomerEnquiryRequest Not Valid.");
                }
                List<Expression<Func<CustomerEnquiry, object>>> customerEnquiryIncluders = new List<Expression<Func<CustomerEnquiry, object>>>();
                customerEnquiryIncluders.Add(x => x.Customer);
                customerEnquiryIncluders.Add(x => x.TechnicalTask);

                customerEnquiry = unitOfWork.CustomerEnquiries.Get(retrieveCustomerEnquiryRequest.getCustomerEnquiryTrackingNumber(), customerEnquiryIncluders);

                if (customerEnquiry == null)
                {
                    throw new CustomerEnquiryDoesNotExist("CustomerEnquiryDoesNotExist");
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
            catch (CustomerEnquiryDoesNotExist e)
            {
                return new RetrieveCustomerEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveCustomerEnquiryResponse().setCustomerEnquiry(customerEnquiry);
        }

        public UpdateCustomerEnquiryResponse UpdateCustomerEnquiry(UpdateCustomerEnquiryRequest updateCustomerEnquiryRequest)
        {
            CustomerEnquiry customerEnquiry = null;
            try
            {
                if (updateCustomerEnquiryRequest.getCustomerEnquiry() == null)
                {
                    throw new RequestNotValid("UpdateCustomerEnquiryRequest Not Valid.");
                }

                customerEnquiry = RetrieveCustomerEnquiry(new RetrieveCustomerEnquiryRequest().setCustomerEnquiryTrackingNumber(
                                         updateCustomerEnquiryRequest.getCustomerEnquiry().TrackingNumber)).getCustomerEnquiry();

                if (customerEnquiry == null)
                {
                    throw new CustomerEnquiryDoesNotExist("CustomerEnquiryDoesNotExist");
                }

                customerEnquiry = updateCustomerEnquiryRequest.getCustomerEnquiry();
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
            catch (CustomerEnquiryDoesNotExist e)
            {
                return new UpdateCustomerEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateCustomerEnquiryResponse().setCustomerEnquiry(customerEnquiry);
        }
    }
}
