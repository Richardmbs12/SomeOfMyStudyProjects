package io.bcteam.product.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.ProductRecordKeeper.*;

import javax.ws.rs.core.Response;

public interface ProductRecordKeeper {
    Response createProduct(
            CreateProductRequest createProductRequest) throws
            RequestNotValidException,
            ProductAlreadyExistsException;

    Response findProducts(
            FindProductsRequest findProductsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    Response removeProduct(
            RemoveProductRequest removeProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductDoesNotExistException,
            ProductNotUniqueException;

    Response retrieveProduct(
            RetrieveProductRequest retrieveProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException;

    Response updateProduct(
            UpdateProductRequest updateProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException;

    /** Local interface */
    interface ProductRecordKeeperLocal extends ProductRecordKeeper {}
}
