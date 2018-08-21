using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.productManagement.product;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.productManagement.product
{
    public class ProductRecordKeeper : IProductRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public ProductRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            try
            {
                if (createProductRequest.getProduct() == null)
                {
                    throw new RequestNotValid("CreateProductRequest Not Valid.");
                }
                Product exceptionTest = RetrieveProduct(new RetrieveProductRequest().setProductSerialNumber(
                    createProductRequest.getProduct().SerialNumber)).getProduct();

                if (exceptionTest != null)
                {
                    throw new ProductAlreadyExists("ProductAlreadyExists");
                }
                unitOfWork.Products.Add(createProductRequest.getProduct());
                unitOfWork.Complete();
            }
            catch (ProductAlreadyExists e)
            {
                return new CreateProductResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateProductResponse();
        }

        public FindProductResponse FindProduct(FindProductRequest findProductRequest)
        {
            List<Product> products = new List<Product>();
            try
            {
                if (findProductRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateProductRequest Not Valid.");
                }

                if (findProductRequest.getSearchCriteria() is AllSearch)
                {
                    List<Expression<Func<Product, object>>> productIncluders = new List<Expression<Func<Product, object>>>();
                    productIncluders.Add(x => x.ProductInstallationHistory);

                    products = unitOfWork.Products.GetAll(productIncluders) as List<Product>;
                }
                // TODO if needed ; Search productEnquiries by certain criteria's.
                //else if (findProductRequest.getSearchCriteria() is ProductSearchCriteria)
                //{
                //    ProductSearchCriteria searchCriterion = (ProductSearchCriteria)findProductRequest.getSearchCriteria();
                //    if (searchCriterion.SearchByValue != null)
                //    {
                //        throw new UnSupportedSearchSerialNumberentifier("When using a spesific mageID, rather use our retrieve form!");
                //    }
                //}
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }
                if (products == null)
                {
                    throw new ProductDoesNotExist("ProductDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindProductResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductDoesNotExist e)
            {
                return new FindProductResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindProductResponse().setProduct(products);
        }

        public RemoveProductResponse RemoveProduct(RemoveProductRequest removeProductRequest)
        {
            try
            {
                if (removeProductRequest.getProduct() == null)
                {
                    throw new RequestNotValid("RemoveProductRequest Not Valid.");
                }
                Product exceptionTest = RetrieveProduct(new RetrieveProductRequest().setProductSerialNumber(
                                         removeProductRequest.getProduct().SerialNumber)).getProduct();

                if (exceptionTest == null)
                {
                    throw new ProductDoesNotExist("ProductDoesNotExist");
                }
                unitOfWork.Products.Remove(removeProductRequest.getProduct());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (ProductDoesNotExist e)
            {
                return new RemoveProductResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveProductResponse();
        }

        public RetrieveProductResponse RetrieveProduct(RetrieveProductRequest retrieveProductRequest)
        {
            Product product = null;
            try
            {
                if (retrieveProductRequest.getProductSerialNumber() == null)
                {
                    throw new RequestNotValid("RetrieveProductRequest Not Valid.");
                }
                List<Expression<Func<Product, object>>> productIncluders = new List<Expression<Func<Product, object>>>();
                productIncluders.Add(x => x.ProductInstallationHistory);

                product = unitOfWork.Products.Get(retrieveProductRequest.getProductSerialNumber(), productIncluders);

                if (product == null)
                {
                    throw new ProductDoesNotExist("ProductDoesNotExist");
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
            catch (ProductDoesNotExist e)
            {
                return new RetrieveProductResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveProductResponse().setProduct(product);
        }

        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            Product product = null;
            try
            {
                if (updateProductRequest.getProduct() == null)
                {
                    throw new RequestNotValid("UpdateProductRequest Not Valid.");
                }

                product = RetrieveProduct(new RetrieveProductRequest().setProductSerialNumber(
                                         updateProductRequest.getProduct().SerialNumber)).getProduct();

                if (product == null)
                {
                    throw new ProductDoesNotExist("ProductDoesNotExist");
                }

                product = updateProductRequest.getProduct();
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
            catch (ProductDoesNotExist e)
            {
                return new UpdateProductResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateProductResponse().setProduct(product);
        }
    }
}
