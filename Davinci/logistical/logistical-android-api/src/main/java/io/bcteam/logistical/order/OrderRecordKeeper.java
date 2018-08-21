package io.bcteam.logistical.order;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.identifier.OrderIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

import java.util.List;

public interface OrderRecordKeeper {
    CreateOrderResponse createOrder(
            CreateOrderRequest createOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyExistsException;

    FindOrdersResponse findOrders(
            FindOrdersRequest findOrdersRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    RemoveOrderResponse removeOrder(
            RemoveOrderRequest removeOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderDoesNotExistException,
            OrderNotUniqueException;

    RetrieveOrderResponse retrieveOrder(
            RetrieveOrderRequest retrieveOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException;

    UpdateOrderResponse updateOrder(
            UpdateOrderRequest updateOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException;

    class CreateOrderResponse extends Response
    {
    }
    class CreateOrderRequest extends Request
    {
        private Order Order;

        public Order getOrder() {
            return Order;
        }

        public CreateOrderRequest setOrder(Order Order) {
            this.Order = Order;
            return this;
        }
    }

    class FindOrdersResponse extends Response
    {
        private List<Order> Orders;

        public List<Order> getOrders() {
            return Orders;
        }

        public FindOrdersResponse setOrders(List<Order> Orders) {
            this.Orders = Orders;
            return this;
        }
    }

    class FindOrdersRequest extends Request
    {
        private SearchCriteria searchCriteria;

        public SearchCriteria getSearchCriteria()
        {
            return searchCriteria;
        }

        public FindOrdersRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
    }

    class UpdateOrderResponse extends Response
    {
    }

    class UpdateOrderRequest extends Request{

        private Order Order;

        private OrderIdentifier orderIdentifier;

        public Order getOrder()
        {
            return Order;
        }

        public UpdateOrderRequest setOrder(Order Order)
        {
            this.Order = Order;
            return this;
        }

        public OrderIdentifier getOrderIdentifier()
        {
            return orderIdentifier;
        }

        public UpdateOrderRequest setOrderIdentifier(OrderIdentifier orderIdentifier)
        {
            this.orderIdentifier = orderIdentifier;
            return this;
        }
    }

    class RemoveOrderResponse extends Response
    {

    }

    class RemoveOrderRequest extends Request
    {
        private OrderIdentifier OrderIdentifier;

        public OrderIdentifier getOrderIdentifier()
        {
            return OrderIdentifier;
        }

        public RemoveOrderRequest setOrderIdentifier(OrderIdentifier OrderIdentifier)
        {
            this.OrderIdentifier = OrderIdentifier;
            return this;
        }
    }

    class RetrieveOrderResponse extends Response
    {
        private Order Order;

        public Order getOrder() {
            return Order;
        }

        public RetrieveOrderResponse setOrder(Order Order) {
            this.Order = Order;
            return this;
        }
    }

    class RetrieveOrderRequest extends Request
    {
        private OrderIdentifier OrderIdentifier;

        public OrderIdentifier getOrderIdentifier() {
            return OrderIdentifier;
        }

        public RetrieveOrderRequest setOrderIdentifier(OrderIdentifier OrderIdentifier) {
            this.OrderIdentifier = OrderIdentifier;
            return this;
        }
    }

    class OrderAlreadyExistsException extends PreconditionViolation
    {
        public OrderAlreadyExistsException() {}

        public OrderAlreadyExistsException(String message)
        {
            super(message);
        }
    }

    class OrderDoesNotExistException extends PreconditionViolation
    {
        public OrderDoesNotExistException() {}

        public OrderDoesNotExistException(String message)
        {
            super(message);
        }
    }

    class UnsupportedOrderIdentifierException extends PreconditionViolation
    {

        public UnsupportedOrderIdentifierException(String message) {
            super(message);
        }

        public UnsupportedOrderIdentifierException() {}
    }

    class OrderNotUniqueException extends PreconditionViolation
    {
        public OrderNotUniqueException() {}

        public OrderNotUniqueException(String message)
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
