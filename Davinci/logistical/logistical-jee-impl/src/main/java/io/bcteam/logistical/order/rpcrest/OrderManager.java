package io.bcteam.logistical.order.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.OrderManager.*;

import javax.ws.rs.core.Response;

public interface OrderManager {

    Response submitOrder(SubmitOrderRequest submitOrderRequest) throws
            RequestNotValidException;

    Response claimOrder(ClaimOrderRequest claimOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyClaimedException;

    Response orderPayment(OrderPaymentRequest orderPaymentRequest) throws
            RequestNotValidException,
            OrderPaymentAlreadyPaidException;
    /** Local interface */
    interface OrderManagerLocal extends OrderManager {}
}
