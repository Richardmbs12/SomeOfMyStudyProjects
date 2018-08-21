using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.productManagement.productType;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.productTypeManagement.productType
{
    public class ProductTypeRecordKeeper : IProductTypeRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public ProductTypeRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateProductTypeResponse CreateProductType(CreateProductTypeRequest createProductTypeRequest)
        {
            try
            {
                if (createProductTypeRequest.getProductType() == null)
                {
                    throw new RequestNotValid("CreateProductTypeRequest Not Valid.");
                }
                ProductType exceptionTest = RetrieveProductType(new RetrieveProductTypeRequest().setProductTypeId(
                    createProductTypeRequest.getProductType().ProductID)).getProductType();

                if (exceptionTest != null)
                {
                    throw new ProductTypeAlreadyExists("ProductTypeAlreadyExists");
                }
                unitOfWork.ProductTypes.Add(createProductTypeRequest.getProductType());
                unitOfWork.Complete();
            }
            catch (ProductTypeAlreadyExists e)
            {
                return new CreateProductTypeResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateProductTypeResponse();
        }

        public FindProductTypeResponse FindProductType(FindProductTypeRequest findProductTypeRequest)
        {
            List<ProductType> productTypes = new List<ProductType>();
            try
            {
                if (findProductTypeRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateProductTypeRequest Not Valid.");
                }

                if (findProductTypeRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<ProductType, object>>> productTypeIncluders = new List<Expression<Func<ProductType, object>>>();
                    productTypeIncluders.Add(x => x.Products);


                    productTypes = unitOfWork.ProductTypes.GetAll(productTypeIncluders) as List<ProductType>;
                }
                // TODO if needed ; Search productTypeEnquiries by certain criteria's.
                //else if (findProductTypeRequest.getSearchCriteria() is ProductTypeSearchCriteria)
                //{
                //    ProductTypeSearchCriteria searchCriterion = (ProductTypeSearchCriteria)findProductTypeRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchProductIDentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (productTypes == null)
                {
                    throw new ProductTypeDoesNotExist("ProductTypeDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindProductTypeResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductTypeDoesNotExist e)
            {
                return new FindProductTypeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindProductTypeResponse().setProductType(productTypes);
        }

        public RemoveProductTypeResponse RemoveProductType(RemoveProductTypeRequest removeProductTypeRequest)
        {
            try
            {
                if (removeProductTypeRequest.getProductType() == null)
                {
                    throw new RequestNotValid("RemoveProductTypeRequest Not Valid.");
                }
                ProductType exceptionTest = RetrieveProductType(new RetrieveProductTypeRequest().setProductTypeId(
                                         removeProductTypeRequest.getProductType().ProductID)).getProductType();

                if (exceptionTest == null)
                {
                    throw new ProductTypeDoesNotExist("ProductTypeDoesNotExist");
                }
                unitOfWork.ProductTypes.Remove(removeProductTypeRequest.getProductType());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductTypeDoesNotExist e)
            {
                return new RemoveProductTypeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveProductTypeResponse();
        }

        public RetrieveProductTypeResponse RetrieveProductType(RetrieveProductTypeRequest retrieveProductTypeRequest)
        {
            ProductType productType = null;
            try
            {
                if (retrieveProductTypeRequest.getProductTypeId() == null)
                {
                    throw new RequestNotValid("RetrieveProductTypeRequest Not Valid.");
                }
                List<Expression<Func<ProductType, object>>> productTypeIncluders = new List<Expression<Func<ProductType, object>>>();
                productTypeIncluders.Add(x => x.Products);

                productType = unitOfWork.ProductTypes.Get(retrieveProductTypeRequest.getProductTypeId(), productTypeIncluders);

                if (productType == null)
                {
                    throw new ProductTypeDoesNotExist("ProductTypeDoesNotExist");
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
            catch (ProductTypeDoesNotExist e)
            {
                return new RetrieveProductTypeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveProductTypeResponse().setProductType(productType);
        }

        public UpdateProductTypeResponse UpdateProductType(UpdateProductTypeRequest updateProductTypeRequest)
        {
            ProductType productType = null;
            try
            {
                if (updateProductTypeRequest.getProductType() == null)
                {
                    throw new RequestNotValid("UpdateProductTypeRequest Not Valid.");
                }

                productType = RetrieveProductType(new RetrieveProductTypeRequest().setProductTypeId(
                                         updateProductTypeRequest.getProductType().ProductID)).getProductType();

                if (productType == null)
                {
                    throw new ProductTypeDoesNotExist("ProductTypeDoesNotExist");
                }

                productType = updateProductTypeRequest.getProductType();
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
            catch (ProductTypeDoesNotExist e)
            {
                return new UpdateProductTypeResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateProductTypeResponse().setProductType(productType);
        }
    }
}

