package io.bcteam.logistical.order.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.OrderRecordKeeper.*;

import javax.ws.rs.core.Response;

public interface OrderRecordKeeper {
    Response createOrder(
            CreateOrderRequest createOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyExistsException;

    Response findOrders(
            FindOrdersRequest findOrdersRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    Response removeOrder(
            RemoveOrderRequest removeOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderDoesNotExistException,
            OrderNotUniqueException;

    Response retrieveOrder(
            RetrieveOrderRequest retrieveOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException;

    Response updateOrder(
            UpdateOrderRequest updateOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException;

    /** Local interface */
    interface OrderRecordKeeperLocal extends OrderRecordKeeper {}
}
