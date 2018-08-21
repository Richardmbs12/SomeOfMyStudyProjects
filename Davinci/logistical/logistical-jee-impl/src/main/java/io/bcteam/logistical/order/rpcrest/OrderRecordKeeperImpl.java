package io.bcteam.logistical.order.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.OrderRecordKeeper.*;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@Path("/logistical/orders")
@Stateless(name = "OrderRecordKeeperRestRpcAdapter")
@Local(OrderRecordKeeper.OrderRecordKeeperLocal.class)
public class OrderRecordKeeperImpl implements OrderRecordKeeper{

    @Inject
    private io.bcteam.logistical.order.OrderRecordKeeper orderRecordKeeper;

    @Override
    @Path("/createorder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response createOrder(CreateOrderRequest createOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyExistsException {
        return Response.ok().entity(orderRecordKeeper.createOrder(createOrderRequest)).build();
    }

    @Override
    @Path("/findpeople")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response findOrders(FindOrdersRequest findOrdersRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {
        return Response.ok().entity(orderRecordKeeper.findOrders(findOrdersRequest)).build();
    }

    @Override
    @Path("/removeorder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response removeOrder(RemoveOrderRequest removeOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderDoesNotExistException,
            OrderNotUniqueException {
        return Response.ok().entity(orderRecordKeeper.removeOrder(removeOrderRequest)).build();
    }

    @Override
    @Path("/retrieveorder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response retrieveOrder(RetrieveOrderRequest retrieveOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException {
        return Response.ok().entity(orderRecordKeeper.retrieveOrder(retrieveOrderRequest)).build();
    }

    @Override
    @Path("/updateorder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response updateOrder(UpdateOrderRequest updateOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException {
        return Response.ok().entity(orderRecordKeeper.updateOrder(updateOrderRequest)).build();
    }
}
