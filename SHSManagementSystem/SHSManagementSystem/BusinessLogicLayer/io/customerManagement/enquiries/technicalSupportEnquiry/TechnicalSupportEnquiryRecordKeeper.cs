using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiry.searchCriteria;
using BusinessLayer.io.customerManagement.enquiries.technicalSupportEnquiryEnquiry;
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

namespace BusinessLogicLayer.io.customerManagement.enquiries.technicalSupportEnquiry
{
    public class TechnicalSupportEnquiryRecordKeeper : ITechnicalSupportEnquiryRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public TechnicalSupportEnquiryRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateTechnicalSupportEnquiryResponse CreateTechnicalSupportEnquiry(CreateTechnicalSupportEnquiryRequest createTechnicalSupportEnquiryRequest)
        {
            try
            {
                if (createTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry() == null)
                {
                    throw new RequestNotValid("CreateTechnicalSupportEnquiryRequest Not Valid.");
                }
                TechnicalSupportEnquiry exceptionTest = RetrieveTechnicalSupportEnquiry(new RetrieveTechnicalSupportEnquiryRequest().setTechnicalSupportEnquiryTrackingNumber(
                    createTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry().TrackingNumber)).getTechnicalSupportEnquiry();

                if (exceptionTest != null)
                {
                    throw new TechnicalSupportEnquiryAlreadyExists("TechnicalSupportEnquiryAlreadyExists");
                }
                unitOfWork.CustomerEnquiries.Add(createTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry());
                unitOfWork.Complete();
            }
            catch (TechnicalSupportEnquiryAlreadyExists e)
            {
                return new CreateTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateTechnicalSupportEnquiryResponse();
        }

        public FindTechnicalSupportEnquiryResponse FindTechnicalSupportEnquiry(FindTechnicalSupportEnquiryRequest findTechnicalSupportEnquiryRequest)
        {
            List<TechnicalSupportEnquiry> technicalSupportEnquiries = new List<TechnicalSupportEnquiry>();
            try
            {
                if (findTechnicalSupportEnquiryRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateTechnicalSupportEnquiryRequest Not Valid.");
                }
                List<Expression<Func<TechnicalSupportEnquiry, object>>> technicalSupportEnquiryIncluders = new List<Expression<Func<TechnicalSupportEnquiry, object>>>();
                technicalSupportEnquiryIncluders.Add(x => x.Customer);
                technicalSupportEnquiryIncluders.Add(x => x.TechnicalTask);
                if (findTechnicalSupportEnquiryRequest.getSearchCriteria() is AllSearch)
                {
                    technicalSupportEnquiries = unitOfWork.TechnicalSupportEnquiries.GetAll(technicalSupportEnquiryIncluders) as List<TechnicalSupportEnquiry>;
                }
                else if (findTechnicalSupportEnquiryRequest.getSearchCriteria() is TechnicalSupportEnquirySearchCriteria)
                {
                    string id = ((TechnicalSupportEnquirySearchCriteria)findTechnicalSupportEnquiryRequest.getSearchCriteria()).getCustomerId();
                    technicalSupportEnquiries = unitOfWork.TechnicalSupportEnquiries.Find(x => x.Customer.ID == id, technicalSupportEnquiryIncluders) as List<TechnicalSupportEnquiry>;
                }
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (technicalSupportEnquiries == null)
                {
                    throw new TechnicalSupportEnquiryDoesNotExist("TechnicalSupportEnquiryDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalSupportEnquiryDoesNotExist e)
            {
                return new FindTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindTechnicalSupportEnquiryResponse().setTechnicalSupportEnquiry(technicalSupportEnquiries);
        }

        public RemoveTechnicalSupportEnquiryResponse RemoveTechnicalSupportEnquiry(RemoveTechnicalSupportEnquiryRequest removeTechnicalSupportEnquiryRequest)
        {
            try
            {
                if (removeTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry() == null)
                {
                    throw new RequestNotValid("RemoveTechnicalSupportEnquiryRequest Not Valid.");
                }
                TechnicalSupportEnquiry exceptionTest = RetrieveTechnicalSupportEnquiry(new RetrieveTechnicalSupportEnquiryRequest().setTechnicalSupportEnquiryTrackingNumber(
                                         removeTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry().TrackingNumber)).getTechnicalSupportEnquiry();

                if (exceptionTest == null)
                {
                    throw new TechnicalSupportEnquiryDoesNotExist("TechnicalSupportEnquiryDoesNotExist");
                }
                unitOfWork.CustomerEnquiries.Remove(removeTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (TechnicalSupportEnquiryDoesNotExist e)
            {
                return new RemoveTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveTechnicalSupportEnquiryResponse();
        }

        public RetrieveTechnicalSupportEnquiryResponse RetrieveTechnicalSupportEnquiry(RetrieveTechnicalSupportEnquiryRequest retrieveTechnicalSupportEnquiryRequest)
        {
            TechnicalSupportEnquiry technicalSupportEnquiry = null;
            try
            {
                if (retrieveTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiryTrackingNumber() == null)
                {
                    throw new RequestNotValid("RetrieveTechnicalSupportEnquiryRequest Not Valid.");
                }
                List<Expression<Func<TechnicalSupportEnquiry, object>>> technicalSupportEnquiryIncluders = new List<Expression<Func<TechnicalSupportEnquiry, object>>>();
                technicalSupportEnquiryIncluders.Add(x => x.Customer);
                technicalSupportEnquiryIncluders.Add(x => x.TechnicalTask);

                technicalSupportEnquiry = unitOfWork.TechnicalSupportEnquiries.Get(retrieveTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiryTrackingNumber(), technicalSupportEnquiryIncluders);

                if (technicalSupportEnquiry == null)
                {
                    throw new TechnicalSupportEnquiryDoesNotExist("TechnicalSupportEnquiryDoesNotExist");
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
            catch (TechnicalSupportEnquiryDoesNotExist e)
            {
                return new RetrieveTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveTechnicalSupportEnquiryResponse().setTechnicalSupportEnquiry(technicalSupportEnquiry);
        }

        public UpdateTechnicalSupportEnquiryResponse UpdateTechnicalSupportEnquiry(UpdateTechnicalSupportEnquiryRequest updateTechnicalSupportEnquiryRequest)
        {
            TechnicalSupportEnquiry technicalSupportEnquiry = null;
            try
            {
                if (updateTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry() == null)
                {
                    throw new RequestNotValid("UpdateTechnicalSupportEnquiryRequest Not Valid.");
                }

                technicalSupportEnquiry = RetrieveTechnicalSupportEnquiry(new RetrieveTechnicalSupportEnquiryRequest().setTechnicalSupportEnquiryTrackingNumber(
                                         updateTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry().TrackingNumber)).getTechnicalSupportEnquiry();

                if (technicalSupportEnquiry == null)
                {
                    throw new TechnicalSupportEnquiryDoesNotExist("TechnicalSupportEnquiryDoesNotExist");
                }

                technicalSupportEnquiry = updateTechnicalSupportEnquiryRequest.getTechnicalSupportEnquiry();
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
            catch (TechnicalSupportEnquiryDoesNotExist e)
            {
                return new UpdateTechnicalSupportEnquiryResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateTechnicalSupportEnquiryResponse().setTechnicalSupportEnquiry(technicalSupportEnquiry);
        }
    }
}
