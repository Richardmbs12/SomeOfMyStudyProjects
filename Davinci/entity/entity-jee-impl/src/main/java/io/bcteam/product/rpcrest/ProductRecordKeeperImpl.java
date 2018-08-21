package io.bcteam.product.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.ProductRecordKeeper.*;
import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@Path("/products")
@Stateless(name = "ProductRecordKeeperRestRpcAdapter")
@Local(ProductRecordKeeper.ProductRecordKeeperLocal.class)
public class ProductRecordKeeperImpl implements ProductRecordKeeper {

    @Inject
    private io.bcteam.entity.product.ProductRecordKeeper productRecordKeeper;

    @Override
    @Path("/createproduct")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response createProduct(io.bcteam.entity.product.ProductRecordKeeper.CreateProductRequest createProductRequest) throws
            RequestNotValidException,
            ProductAlreadyExistsException {
        return Response.ok().entity(productRecordKeeper.createProduct(createProductRequest)).build();
    }

    @Override
    @Path("/findproducts")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response findProducts(FindProductsRequest findProductsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {
        return Response.ok().entity(productRecordKeeper.findProducts(findProductsRequest)).build();
    }

    @Override
    @Path("/removeproduct")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response removeProduct(RemoveProductRequest removeProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductDoesNotExistException,
            ProductNotUniqueException {
        return Response.ok().entity(productRecordKeeper.removeProduct(removeProductRequest)).build();
    }

    @Override
    @Path("/retrieveproduct")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response retrieveProduct(RetrieveProductRequest retrieveProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException {
        return Response.ok().entity(productRecordKeeper.retrieveProduct(retrieveProductRequest)).build();
    }

    @Override
    @Path("/updateproduct")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response updateProduct(UpdateProductRequest updateProductRequest) throws
            RequestNotValidException,
            UnsupportedProductIdentifierException,
            ProductNotUniqueException,
            ProductDoesNotExistException {
        return Response.ok().entity(productRecordKeeper.updateProduct(updateProductRequest)).build();
    }
}
