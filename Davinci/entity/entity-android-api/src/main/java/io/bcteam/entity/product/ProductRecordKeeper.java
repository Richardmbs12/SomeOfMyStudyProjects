package io.bcteam.entity.product;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.identifier.ProductIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

import java.util.List;

public interface ProductRecordKeeper {
    CreateProductResponse createProduct(
            CreateProductRequest createProductRequest) throws
            RequestNotValidException,
            ProductAlreadyExistsException;

    FindProductsResponse findProducts(
            FindProductsRequest findProductsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    RemoveProductResponse removeProduct(
            RemoveProductRequest removeProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductDoesNotExistException,
            ProductNotUniqueException;

    RetrieveProductResponse retrieveProduct(
            RetrieveProductRequest retrieveProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException;

    UpdateProductResponse updateProduct(
            UpdateProductRequest updateProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException;

    class CreateProductResponse extends Response
    {
    }
    class CreateProductRequest extends Request
    {
        private Product Product;

        public Product getProduct() {
            return Product;
        }

        public CreateProductRequest setProduct(Product Product) {
            this.Product = Product;
            return this;
        }
    }

    class FindProductsResponse extends Response
    {
        private List<Product> Products;

        private Long recordCount;

        public List<Product> getProducts() {
            return Products;
        }

        public FindProductsResponse setProducts(List<Product> Products) {
            this.Products = Products;
            return this;
        }
    }

    class FindProductsRequest extends Request
    {
        private SearchCriteria searchCriteria;

        public SearchCriteria getSearchCriteria()
        {
            return searchCriteria;
        }

        public FindProductsRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
    }

    class UpdateProductResponse extends Response
    {
    }

    class UpdateProductRequest extends Request{

        private Product Product;

        private ProductIdentifier productIdentifier;

        public Product getProduct()
        {
            return Product;
        }

        public UpdateProductRequest setProduct(Product Product)
        {
            this.Product = Product;
            return this;
        }

        public ProductIdentifier getProductIdentifier()
        {
            return productIdentifier;
        }

        public UpdateProductRequest setProductIdentifier(ProductIdentifier productIdentifier)
        {
            this.productIdentifier = productIdentifier;
            return this;
        }
    }

    class RemoveProductResponse extends Response
    {

    }

    class RemoveProductRequest extends Request
    {
        private ProductIdentifier ProductIdentifier;

        public ProductIdentifier getProductIdentifier()
        {
            return ProductIdentifier;
        }

        public RemoveProductRequest setProductIdentifier(ProductIdentifier ProductIdentifier)
        {
            this.ProductIdentifier = ProductIdentifier;
            return this;
        }
    }

    class RetrieveProductResponse extends Response
    {
        private Product Product;

        public Product getProduct() {
            return Product;
        }

        public RetrieveProductResponse setProduct(Product Product) {
            this.Product = Product;
            return this;
        }
    }

    class RetrieveProductRequest extends Request
    {
        private ProductIdentifier ProductIdentifier;

        public ProductIdentifier getProductIdentifier() {
            return ProductIdentifier;
        }

        public RetrieveProductRequest setProductIdentifier(ProductIdentifier ProductIdentifier) {
            this.ProductIdentifier = ProductIdentifier;
            return this;
        }
    }

    class ProductAlreadyExistsException extends PreconditionViolation
    {
        public ProductAlreadyExistsException() {}

        public ProductAlreadyExistsException(String message)
        {
            super(message);
        }
    }

    class ProductDoesNotExistException extends PreconditionViolation
    {
        public ProductDoesNotExistException() {}

        public ProductDoesNotExistException(String message)
        {
            super(message);
        }
    }

    class UnsupportedProductIdentifierException extends PreconditionViolation
    {

        public UnsupportedProductIdentifierException(String message) {
            super(message);
        }

        public UnsupportedProductIdentifierException() {}
    }

    class ProductNotUniqueException extends PreconditionViolation
    {
        public ProductNotUniqueException() {}

        public ProductNotUniqueException(String message)
        {
            super(message);
        }
    }

    class UnsupportedSearchCriteriaException extends PreconditionViolation
    {
        public UnsupportedSearchCriteriaException() {}

        public UnsupportedSearchCriteriaException(String message)
        {
            super(message);
        }
    }
}
