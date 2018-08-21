package io.bcteam.logistical.order;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.logistical.order.identifier.OrderIdentifier;
import io.bcteam.financial.payment.Payment;
import io.bcteam.security.account.identifier.AccountIdentifier;

public interface OrderManager {

    SubmitOrderResponse submitOrder(SubmitOrderRequest submitOrderRequest) throws
            RequestNotValidException;

    ClaimOrderResponse claimOrder(ClaimOrderRequest claimOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyClaimedException;

    OrderPaymentResponse orderPayment(OrderPaymentRequest orderPaymentRequest) throws
            RequestNotValidException,
            OrderPaymentAlreadyPaidException;

    class OrderPaymentRequest extends Request
    {
        private OrderIdentifier order;
        private Payment payment;

        public Payment getPayment()
        {
            return payment;
        }

        public OrderPaymentRequest setPayment(Payment payment)
        {
            this.payment = payment;
            return this;
        }

        public OrderIdentifier getOrder()
        {
            return order;
        }

        public OrderPaymentRequest setOrder(OrderIdentifier order)
        {
            this.order = order;
            return this;
        }
    }

    class OrderPaymentResponse extends Response {

    }

    class ClaimOrderRequest extends Request
    {
        private OrderIdentifier order;

        public OrderIdentifier getOrder()
        {
            return order;
        }

        public ClaimOrderRequest setOrder(OrderIdentifier order)
        {
            this.order = order;
            return this;
        }
    }

    class ClaimOrderResponse extends Response {
        private Order order;

        public Order getOrder()
        {
            return order;
        }

        public ClaimOrderResponse setOrder(Order order)
        {
            this.order = order;
            return this;
        }
    }

    class SubmitOrderRequest extends Request
    {
        private Order order;

        private AccountIdentifier account;

        public AccountIdentifier getAccount() {
            return account;
        }

        public SubmitOrderRequest setAccount(AccountIdentifier account) {
            this.account = account;
            return this;
        }

        public Order getOrder()
        {
            return order;
        }

        public SubmitOrderRequest setOrder(Order order)
        {
            this.order = order;
            return this;
        }
    }

    class SubmitOrderResponse extends Response {

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

    class OrderAlreadyClaimedException extends PreconditionViolation
    {
        public OrderAlreadyClaimedException() {}

        public OrderAlreadyClaimedException(String message)
        {
            super(message);
        }
    }

    class OrderPaymentAlreadyPaidException extends PreconditionViolation
    {
        public OrderPaymentAlreadyPaidException() {}

        public OrderPaymentAlreadyPaidException(String message)
        {
            super(message);
        }
    }
    interface OrderManagerRemote extends OrderManager {}
    interface OrderManagerLocal extends OrderManager {}
}
