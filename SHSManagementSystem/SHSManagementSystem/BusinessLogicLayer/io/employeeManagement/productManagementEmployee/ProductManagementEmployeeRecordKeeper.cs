using BusinessLayer.io.employeeManagement.productManagementEmployee;
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

namespace BusinessLogicLayer.io.productManagementEmployeeManagement.productManagementProductManagementEmployee
{
    public class ProductManagementEmployeeRecordKeeper : IProductManagementEmployeeRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public ProductManagementEmployeeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateProductManagementEmployeeResponse CreateProductManagementEmployee(CreateProductManagementEmployeeRequest createProductManagementEmployeeRequest)
        {
            try
            {
                if (createProductManagementEmployeeRequest.getProductManagementEmployee() == null)
                {
                    throw new RequestNotValid("CreateProductManagementEmployeeRequest Not Valid.");
                }
                ProductManagementEmployee exceptionTest = RetrieveProductManagementEmployee(new RetrieveProductManagementEmployeeRequest().setProductManagementEmployeeId(
                    createProductManagementEmployeeRequest.getProductManagementEmployee().ID)).getProductManagementEmployee();

                if (exceptionTest != null)
                {
                    throw new ProductManagementEmployeeAlreadyExists("ProductManagementEmployeeAlreadyExists");
                }
                unitOfWork.ProductManagementEmployees.Add(createProductManagementEmployeeRequest.getProductManagementEmployee());
                unitOfWork.Complete();
            }
            catch (ProductManagementEmployeeAlreadyExists e)
            {
                return new CreateProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateProductManagementEmployeeResponse();
        }

        public FindProductManagementEmployeeResponse FindProductManagementEmployee(FindProductManagementEmployeeRequest findProductManagementEmployeeRequest)
        {
            List<ProductManagementEmployee> productManagementEmployees = new List<ProductManagementEmployee>();
            try
            {
                if (findProductManagementEmployeeRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateProductManagementEmployeeRequest Not Valid.");
                }

                if (findProductManagementEmployeeRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<ProductManagementEmployee, object>>> productManagementEmployeeIncluders = new List<Expression<Func<ProductManagementEmployee, object>>>();
                    productManagementEmployeeIncluders.Add(x => x.Address);
                    productManagementEmployeeIncluders.Add(x => x.ContactInformation);
                    productManagementEmployeeIncluders.Add(x => x.LoginDetails);
                    //productManagementEmployeeIncluders.Add(x => x.BillingInformation);
                    //productManagementEmployeeIncluders.Add(x => x.ProductConfiguration);

                    productManagementEmployees = unitOfWork.ProductManagementEmployees.GetAll(productManagementEmployeeIncluders) as List<ProductManagementEmployee>;
                }
                // TODO if needed ; Search productManagementEmployees by certain criteria's.
                //else if (findProductManagementEmployeeRequest.getSearchCriteria() is ProductManagementEmployeeSearchCriteria)
                //{
                //    ProductManagementEmployeeSearchCriteria searchCriterion = (ProductManagementEmployeeSearchCriteria)findProductManagementEmployeeRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchIdentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (productManagementEmployees == null)
                {
                    throw new ProductManagementEmployeeDoesNotExist("ProductManagementEmployeeDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductManagementEmployeeDoesNotExist e)
            {
                return new FindProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindProductManagementEmployeeResponse().setProductManagementEmployee(productManagementEmployees);
        }

        public RemoveProductManagementEmployeeResponse RemoveProductManagementEmployee(RemoveProductManagementEmployeeRequest removeProductManagementEmployeeRequest)
        {
            try
            {
                if (removeProductManagementEmployeeRequest.getProductManagementEmployee() == null)
                {
                    throw new RequestNotValid("RemoveProductManagementEmployeeRequest Not Valid.");
                }
                ProductManagementEmployee exceptionTest = RetrieveProductManagementEmployee(new RetrieveProductManagementEmployeeRequest().setProductManagementEmployeeId(
                                         removeProductManagementEmployeeRequest.getProductManagementEmployee().ID)).getProductManagementEmployee();

                if (exceptionTest == null)
                {
                    throw new ProductManagementEmployeeDoesNotExist("ProductManagementEmployeeDoesNotExist");
                }
                unitOfWork.ProductManagementEmployees.Remove(removeProductManagementEmployeeRequest.getProductManagementEmployee());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductManagementEmployeeDoesNotExist e)
            {
                return new RemoveProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveProductManagementEmployeeResponse();
        }

        public RetrieveProductManagementEmployeeResponse RetrieveProductManagementEmployee(RetrieveProductManagementEmployeeRequest retrieveProductManagementEmployeeRequest)
        {
            ProductManagementEmployee productManagementEmployee = null;
            try
            {
                if (retrieveProductManagementEmployeeRequest.getProductManagementEmployeeId() == null)
                {
                    throw new RequestNotValid("RetrieveProductManagementEmployeeRequest Not Valid.");
                }
                List<Expression<Func<ProductManagementEmployee, object>>> productManagementEmployeeIncluders = new List<Expression<Func<ProductManagementEmployee, object>>>();
                productManagementEmployeeIncluders.Add(x => x.Address);
                productManagementEmployeeIncluders.Add(x => x.ContactInformation);
                productManagementEmployeeIncluders.Add(x => x.LoginDetails);
                //productManagementEmployeeIncluders.Add(x => x.BillingInformation);
                //productManagementEmployeeIncluders.Add(x => x.ProductConfiguration);
                productManagementEmployee = unitOfWork.ProductManagementEmployees.Get(retrieveProductManagementEmployeeRequest.getProductManagementEmployeeId(), productManagementEmployeeIncluders);

                if (productManagementEmployee == null)
                {
                    throw new ProductManagementEmployeeDoesNotExist("ProductManagementEmployeeDoesNotExist");
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
            catch (ProductManagementEmployeeDoesNotExist e)
            {
                return new RetrieveProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveProductManagementEmployeeResponse().setProductManagementEmployee(productManagementEmployee);
        }

        public UpdateProductManagementEmployeeResponse UpdateProductManagementEmployee(UpdateProductManagementEmployeeRequest updateProductManagementEmployeeRequest)
        {
            ProductManagementEmployee productManagementEmployee = null;
            try
            {
                if (updateProductManagementEmployeeRequest.getProductManagementEmployee() == null)
                {
                    throw new RequestNotValid("UpdateProductManagementEmployeeRequest Not Valid.");
                }

                productManagementEmployee = RetrieveProductManagementEmployee(new RetrieveProductManagementEmployeeRequest().setProductManagementEmployeeId(
                                         updateProductManagementEmployeeRequest.getProductManagementEmployee().ID)).getProductManagementEmployee();

                if (productManagementEmployee == null)
                {
                    throw new ProductManagementEmployeeDoesNotExist("ProductManagementEmployeeDoesNotExist");
                }

                productManagementEmployee = updateProductManagementEmployeeRequest.getProductManagementEmployee();
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
            catch (ProductManagementEmployeeDoesNotExist e)
            {
                return new UpdateProductManagementEmployeeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateProductManagementEmployeeResponse().setProductManagementEmployee(productManagementEmployee);
        }
    }
    }
