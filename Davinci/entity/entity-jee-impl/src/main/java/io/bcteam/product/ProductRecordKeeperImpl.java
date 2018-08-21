package io.bcteam.product;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.Product;
import io.bcteam.entity.product.ProductRecordKeeper;
import io.bcteam.entity.product.identifier.ProductIdentifier;
import io.bcteam.entity.product.identifier.ProductName;
import io.bcteam.entity.product.search.criteria.ProductIdentifierSearch;
import io.bcteam.search.criteria.AllSearch;

import java.util.ArrayList;
import java.util.List;

public class ProductRecordKeeperImpl implements ProductRecordKeeper.ProductRecordKeeperLocal,
        ProductRecordKeeper.ProductRecordKeeperRemote {

    @Override
    public CreateProductResponse createProduct(CreateProductRequest createProductRequest) throws 
            RequestNotValidException, 
            ProductAlreadyExistsException {
        
        if (createProductRequest.getProduct()==null){
            throw new RequestNotValidException("Product must be provided.");
        }

        /**
         * TODO Check if product already exists and throw ProductAlreadyExistsException accordingly.
         */

        /**
         * TODO Persist Product To Database
         */
        
        return new CreateProductResponse();
    }

    @Override
    public FindProductsResponse findProducts(FindProductsRequest findProductsRequest) throws 
            RequestNotValidException, 
            UnsupportedSearchCriteriaException {

        if (findProductsRequest.getSearchCriteria() == null){
            throw new RequestNotValidException("ProductSearchCriteria must be provided.");
        }

        if (findProductsRequest.getSearchCriteria() instanceof ProductIdentifierSearch) {
            if (((ProductIdentifierSearch) findProductsRequest.getSearchCriteria()).getProductIdentifier() instanceof ProductName){
                throw new RuntimeException("ProductIdentifierSearch not allowed for findProducts. " +
                        "Use retrieveProduct.");
            }
            else {
                throw new RuntimeException("ProductIdentifierSearch not allowed for findProducts. " +
                        "Use retrieveProduct.");
            }
        } else if (findProductsRequest.getSearchCriteria() instanceof AllSearch) {
            /**
             * TODO Find all products from database.
             */
        }
        else {
            throw new UnsupportedSearchCriteriaException("Search Criteria is not supported for find products.");
        }

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        List<Product> products = new ArrayList<>();
        products.add(
                new Product()
                .setDescription("Description")
                .setName("Name")
                .setPrice(100.00)
                .setSerial("SerialNumber")
                .setStockAvailable(10));

        /**
         * Above is just mock implementation to get server started without relying on database.
         */
        
        return new FindProductsResponse().setProducts(products);
    }

    @Override
    public RemoveProductResponse removeProduct(RemoveProductRequest removeProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductDoesNotExistException,
            ProductNotUniqueException {

        if (removeProductRequest.getProductIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(removeProductRequest.getProductIdentifier() instanceof ProductIdentifier)){
            throw new UnsupportedProductIdentifierException(
                    "Identifier is not instance of ProductIdentifier.");
        }

        Product product = retrieveProduct(new RetrieveProductRequest().setProductIdentifier(removeProductRequest.getProductIdentifier())).getProduct();

        /**
         * TODO Remove Product From Database
         */
        
        return new RemoveProductResponse();
    }

    @Override
    public RetrieveProductResponse retrieveProduct(RetrieveProductRequest retrieveProductRequest) throws 
            RequestNotValidException, 
            UnsupportedProductIdentifierException, 
            ProductNotUniqueException, 
            ProductDoesNotExistException {
        
        if (retrieveProductRequest.getProductIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(retrieveProductRequest.getProductIdentifier() instanceof ProductIdentifier)){
            throw new UnsupportedProductIdentifierException(
                    "Identifier is not instance of ProductIdentifier.");
        }
        /**
         * TODO Retrieve Products From Database
         */

        /**
         * TODO Validate that only one product returns otherwise -> ProductNotUniqueException
         */

        /**
         * TODO Validate that at least a product returns -> ProductDoesNotExistException
         */

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        /**
         * TODO Retrieve Product From Database
         */
        Product product = new Product()
                        .setDescription("Description")
                        .setName("Name")
                        .setPrice(100.00)
                        .setSerial("SerialNumber")
                        .setStockAvailable(10);

        /**
         * Above is just mock implementation to get server started without relying on database.
         */
        
        return new RetrieveProductResponse().setProduct(product);
    }

    @Override
    public UpdateProductResponse updateProduct(UpdateProductRequest updateProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException {

        Product product = updateProductRequest.getProduct();

        if (product == null || updateProductRequest.getProductIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(updateProductRequest.getProductIdentifier() instanceof ProductIdentifier)){
            throw new UnsupportedProductIdentifierException(
                    "Identifier is not instance of ProductIdentifier.");
        }

        Product productEntity = retrieveProduct(new RetrieveProductRequest().setProductIdentifier(updateProductRequest.getProductIdentifier())).getProduct();

        /* Update only the fields that may be updated */
        productEntity.setStockAvailable(product.getStockAvailable());
        productEntity.setDescription(product.getDescription());
        productEntity.setName(product.getName());
        productEntity.setPrice(product.getPrice());
        
        /**
         * TODO Update Product From Database
         */

        return new UpdateProductResponse();
    }
}
