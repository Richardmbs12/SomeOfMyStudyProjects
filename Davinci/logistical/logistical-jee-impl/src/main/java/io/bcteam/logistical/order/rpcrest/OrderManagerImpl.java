package io.bcteam.logistical.order.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.OrderManager.*;

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
@Stateless(name = "OrderManagerRestRpcAdapter")
@Local(OrderRecordKeeper.OrderRecordKeeperLocal.class)
public class OrderManagerImpl implements OrderManager{

    @Inject
    private io.bcteam.logistical.order.OrderManager orderManager;

    @Override
    @Path("/submitOrder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response submitOrder(SubmitOrderRequest submitOrderRequest) throws
            RequestNotValidException {
        return Response.ok().entity(orderManager.submitOrder(submitOrderRequest)).build();
    }

    @Override
    @Path("/claimOrder")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response claimOrder(ClaimOrderRequest claimOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyClaimedException {
        return Response.ok().entity(orderManager.claimOrder(claimOrderRequest)).build();
    }

    @Override
    @Path("/orderPayment")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response orderPayment(OrderPaymentRequest orderPaymentRequest) throws
            RequestNotValidException,
            OrderPaymentAlreadyPaidException {
        return Response.ok().entity(orderManager.orderPayment(orderPaymentRequest)).build();
    }
}
