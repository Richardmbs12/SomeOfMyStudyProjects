using BusinessLayer.io.billingInvoiceManagement.billingInvoice.billing;
using BusinessLayer.io.customerManagement.customer.billing;
using BusinessLayer.io.customerManagement.customer.billing.searchCriteria;
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

namespace BusinessLogicLayer.io.customerManagement.customer.billing
{
    public class BillingInvoiceRecordKeeper : IBillingInvoiceRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public BillingInvoiceRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateBillingInvoiceResponse CreateBillingInvoice(CreateBillingInvoiceRequest createBillingInvoiceRequest)
        {
            try
            {
                if (createBillingInvoiceRequest.getBillingInvoice() == null)
                {
                    throw new RequestNotValid("CreateBillingInvoiceRequest Not Valid.");
                }
                BillingInvoice exceptionTest = RetrieveBillingInvoice(new RetrieveBillingInvoiceRequest().setBillingInvoiceId(
                    createBillingInvoiceRequest.getBillingInvoice().OrderID)).getBillingInvoice();

                if (exceptionTest != null)
                {
                    throw new BillingInvoiceAlreadyExists("BillingInvoiceAlreadyExists");
                }
                unitOfWork.BillingInvoices.Add(createBillingInvoiceRequest.getBillingInvoice());
                unitOfWork.Complete();
            }
            catch (BillingInvoiceAlreadyExists e)
            {
                return new CreateBillingInvoiceResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateBillingInvoiceResponse();
        }

        public FindBillingInvoiceResponse FindBillingInvoice(FindBillingInvoiceRequest findBillingInvoiceRequest)
        {
            List<BillingInvoice> billingInvoices = new List<BillingInvoice>();
            try
            {
                if (findBillingInvoiceRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateBillingInvoiceRequest Not Valid.");
                }

                List<Expression<Func<BillingInvoice, object>>> billingInvoiceIncluders = new List<Expression<Func<BillingInvoice, object>>>();

                if (findBillingInvoiceRequest.getSearchCriteria() is AllSearch)
                {
                    billingInvoices = unitOfWork.BillingInvoices.GetAll(billingInvoiceIncluders) as List<BillingInvoice>;
                }
                else if (findBillingInvoiceRequest.getSearchCriteria() is BillingInvoiceSearchCriteria)
                {

                    BillingInvoiceSearchCriteria searchCriterion = (BillingInvoiceSearchCriteria)findBillingInvoiceRequest.getSearchCriteria();

                    billingInvoices = unitOfWork.BillingInvoices.Find(x => x.BillingInformation.ID == searchCriterion.getCustomerId(), billingInvoiceIncluders) as List<BillingInvoice>;
                }
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (billingInvoices == null)
                {
                    throw new BillingInvoiceDoesNotExist("BillingInvoiceDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindBillingInvoiceResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (BillingInvoiceDoesNotExist e)
            {
                return new FindBillingInvoiceResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindBillingInvoiceResponse().setBillingInvoice(billingInvoices);
        }

        public RemoveBillingInvoiceResponse RemoveBillingInvoice(RemoveBillingInvoiceRequest removeBillingInvoiceRequest)
        {
            try
            {
                if (removeBillingInvoiceRequest.getBillingInvoice() == null)
                {
                    throw new RequestNotValid("RemoveBillingInvoiceRequest Not Valid.");
                }
                BillingInvoice exceptionTest = RetrieveBillingInvoice(new RetrieveBillingInvoiceRequest().setBillingInvoiceId(
                    removeBillingInvoiceRequest.getBillingInvoice().OrderID)).getBillingInvoice();

                if (exceptionTest == null)
                {
                    throw new BillingInvoiceDoesNotExist("BillingInvoiceDoesNotExist");
                }
                unitOfWork.BillingInvoices.Remove(removeBillingInvoiceRequest.getBillingInvoice());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (BillingInvoiceDoesNotExist e)
            {
                return new RemoveBillingInvoiceResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveBillingInvoiceResponse();
        }

        public RetrieveBillingInvoiceResponse RetrieveBillingInvoice(RetrieveBillingInvoiceRequest retrieveBillingInvoiceRequest)
        {
            BillingInvoice billingInvoice = null;
            try
            {
                if (retrieveBillingInvoiceRequest.getBillingInvoiceId() == null)
                {
                    throw new RequestNotValid("RetrieveBillingInvoiceRequest Not Valid.");
                }
                List<Expression<Func<BillingInvoice, object>>> billingInvoiceIncluders = new List<Expression<Func<BillingInvoice, object>>>();
                billingInvoice = unitOfWork.BillingInvoices.Get(retrieveBillingInvoiceRequest.getBillingInvoiceId());

                if (billingInvoice == null)
                {
                    throw new BillingInvoiceDoesNotExist("BillingInvoiceDoesNotExist");
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
            catch (BillingInvoiceDoesNotExist e)
            {
                return new RetrieveBillingInvoiceResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveBillingInvoiceResponse().setBillingInvoice(billingInvoice);
        }

        public UpdateBillingInvoiceResponse UpdateBillingInvoice(UpdateBillingInvoiceRequest updateBillingInvoiceRequest)
        {
            BillingInvoice billingInvoice = null;
            try
            {
                if (updateBillingInvoiceRequest.getBillingInvoice() == null)
                {
                    throw new RequestNotValid("UpdateBillingInvoiceRequest Not Valid.");
                }

                billingInvoice = RetrieveBillingInvoice(new RetrieveBillingInvoiceRequest().setBillingInvoiceId(
                    updateBillingInvoiceRequest.getBillingInvoice().OrderID)).getBillingInvoice();

                if (billingInvoice == null)
                {
                    throw new BillingInvoiceDoesNotExist("BillingInvoiceDoesNotExist");
                }

                billingInvoice = updateBillingInvoiceRequest.getBillingInvoice();
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
            catch (BillingInvoiceDoesNotExist e)
            {
                return new UpdateBillingInvoiceResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateBillingInvoiceResponse().setBillingInvoice(billingInvoice);
        }
    }
}
