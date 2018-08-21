using BusinessLayer.io.customerManagement.customer.contract;
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

namespace BusinessLogicLayer.io.contractTypeManagement.contractType.contract
{
    public class ContractTypeRecordKeeper : IContractTypeRecordKeeper
    {
    private IUnitOfWork unitOfWork;
    private IFileHandler fileHandler;
    public ContractTypeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
    {
        this.unitOfWork = unitOfWork;
        this.fileHandler = fileHandler;
    }
    public CreateContractTypeResponse CreateContractType(CreateContractTypeRequest createContractTypeRequest)
    {
        try
        {
            if (createContractTypeRequest.getContractType() == null)
            {
                throw new RequestNotValid("CreateContractTypeRequest Not Valid.");
            }

            //Generation of Contract ID

                Random rnd = new Random();
                int contractTypeLetter = rnd.Next(64, 91);
                string key = rnd.Next(0, 999999).ToString("000000");
                char contractServiceLevelLetter = 'Z';
                ContractType contractType = createContractTypeRequest.getContractType();

                switch (contractType.ServiceLevel)
                {
                    case ServiceLevel.EntryLevel:
                        contractServiceLevelLetter = 'A';
                        break;
                    case ServiceLevel.Deluxe:
                        contractServiceLevelLetter = 'B';
                        break;
                    case ServiceLevel.Premium:
                        contractServiceLevelLetter = 'C';
                        break;
                    case ServiceLevel.Ultimate:
                        contractServiceLevelLetter = 'D';
                        break;
                    default:
                        break;
                }

                contractType.ContractID = DateTime.UtcNow.Year.ToString() + Convert.ToChar(contractTypeLetter) + contractServiceLevelLetter + key;

                ContractType exceptionTest = RetrieveContractType(new RetrieveContractTypeRequest().setContractTypeId(contractType.ContractID)).getContractType();

            if (exceptionTest != null)
            {
                throw new ContractTypeAlreadyExists("ContractTypeAlreadyExists");
            }
            unitOfWork.ContractTypes.Add(createContractTypeRequest.getContractType());
            unitOfWork.Complete();
        }
        catch (ContractTypeAlreadyExists e)
        {
            return new CreateContractTypeResponse().setError(e.Message);
        }
        catch (RequestNotValid e)
        {
            fileHandler.AppendToTxt(new List<string>() { e.Message });
        }
        catch (Exception e)
        {
            fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

        }
        return new CreateContractTypeResponse();
    }

    public FindContractTypeResponse FindContractType(FindContractTypeRequest findContractTypeRequest)
    {
        List<ContractType> contractTypes = new List<ContractType>();
        try
        {
            if (findContractTypeRequest.getSearchCriteria() == null)
            {
                throw new RequestNotValid("CreateContractTypeRequest Not Valid.");
            }

            if (findContractTypeRequest.getSearchCriteria() is AllSearch)
            {
                List<Expression<Func<ContractType, object>>> contractTypeIncluders = new List<Expression<Func<ContractType, object>>>();

                contractTypes = unitOfWork.ContractTypes.GetAll(contractTypeIncluders) as List<ContractType>;
            }
            // TODO if needed ; Search contractTypes by certain criteria's.
            //else if (findContractTypeRequest.getSearchCriteria() is ContractTypeSearchCriteria)
            //{
            //    ContractTypeSearchCriteria searchCriterion = (ContractTypeSearchCriteria)findContractTypeRequest.getSearchCriteria();
            //    if (searchCriterion.SearchByValue != null)
            //    {
            //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
            //    }
            //}
            else
            {
                throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
            }
            if (contractTypes == null)
            {
                throw new ContractTypeDoesNotExist("ContractTypeDoesNotExist");
            }
        }
        catch (RequestNotValid e)
        {
            fileHandler.AppendToTxt(new List<string>() { e.Message });
        }
        catch (UnSupportedSearchIdentifier e)
        {
            return new FindContractTypeResponse().setError(e.Message);
        }
        catch (UnsupportedSearchCriteria e)
        {
            fileHandler.AppendToTxt(new List<string>() { e.Message });
        }
        catch (ContractTypeDoesNotExist e)
        {
            return new FindContractTypeResponse().setError(e.Message);
        }
        catch (Exception e)
        {
            fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
        }
        return new FindContractTypeResponse().setContractType(contractTypes);
    }

    public RemoveContractTypeResponse RemoveContractType(RemoveContractTypeRequest removeContractTypeRequest)
    {
        try
        {
            if (removeContractTypeRequest.getContractType() == null)
            {
                throw new RequestNotValid("RemoveContractTypeRequest Not Valid.");
            }
            ContractType contractType = RetrieveContractType(new RetrieveContractTypeRequest().setContractTypeId(
                                     removeContractTypeRequest.getContractType().ContractID)).getContractType();

            if (contractType == null)
            {
                throw new ContractTypeDoesNotExist("ContractTypeDoesNotExist");
            }
            unitOfWork.ContractTypes.Remove(removeContractTypeRequest.getContractType());
            unitOfWork.Complete();
        }
        catch (RequestNotValid e)
        {
            fileHandler.AppendToTxt(new List<string>() { e.Message });
        }
        catch (ContractTypeDoesNotExist e)
        {
            return new RemoveContractTypeResponse().setError(e.Message);
        }
        catch (Exception e)
        {
            fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
        }
        return new RemoveContractTypeResponse();
    }

    public RetrieveContractTypeResponse RetrieveContractType(RetrieveContractTypeRequest retrieveContractTypeRequest)
    {
        ContractType contractType = null;
        try
        {
            if (retrieveContractTypeRequest.getContractTypeId() == null)
            {
                throw new RequestNotValid("RetrieveContractTypeRequest Not Valid.");
            }
            List<Expression<Func<ContractType, object>>> contractTypeIncluders = new List<Expression<Func<ContractType, object>>>();

            contractType = unitOfWork.ContractTypes.Get(retrieveContractTypeRequest.getContractTypeId(), contractTypeIncluders);

            if (contractType == null)
            {
                throw new ContractTypeDoesNotExist("ContractTypeDoesNotExist");
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
        catch (ContractTypeDoesNotExist e)
        {
            return new RetrieveContractTypeResponse().setError(e.Message);
        }
        catch (Exception e)
        {
            fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
        }

        return new RetrieveContractTypeResponse().setContractType(contractType);
    }

    public UpdateContractTypeResponse UpdateContractType(UpdateContractTypeRequest updateContractTypeRequest)
    {
        ContractType contractType = null;
        try
        {
            if (updateContractTypeRequest.getContractType() == null)
            {
                throw new RequestNotValid("UpdateContractTypeRequest Not Valid.");
            }

            contractType = RetrieveContractType(new RetrieveContractTypeRequest().setContractTypeId(
                                     updateContractTypeRequest.getContractType().ContractID)).getContractType();

            if (contractType == null)
            {
                throw new ContractTypeDoesNotExist("ContractTypeDoesNotExist");
            }

            contractType = updateContractTypeRequest.getContractType();
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
        catch (ContractTypeDoesNotExist e)
        {
            return new UpdateContractTypeResponse().setError(e.Message);
        }
        catch (Exception e)
        {
            fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
        }
        return new UpdateContractTypeResponse().setContractType(contractType);
    }
}
}
