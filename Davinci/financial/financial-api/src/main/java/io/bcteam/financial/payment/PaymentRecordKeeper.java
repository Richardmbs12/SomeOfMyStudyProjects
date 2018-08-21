package io.bcteam.financial.payment;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.financial.payment.identifier.PaymentIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

import java.util.List;

public interface PaymentRecordKeeper {
    CreatePaymentResponse createPayment(
            CreatePaymentRequest createPaymentRequest) throws
            RequestNotValidException,
            PaymentAlreadyExistsException;

    FindPaymentsResponse findPayments(
            FindPaymentsRequest findPaymentsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    RemovePaymentResponse removePayment(
            RemovePaymentRequest removePaymentRequest) throws
            RequestNotValidException,
            UnsupportedPaymentIdentifierException,
            PaymentDoesNotExistException,
            PaymentNotUniqueException;

    RetrievePaymentResponse retrievePayment(
            RetrievePaymentRequest retrievePaymentRequest) throws
            RequestNotValidException,
            UnsupportedPaymentIdentifierException,
            PaymentNotUniqueException,
            PaymentDoesNotExistException;

    UpdatePaymentResponse updatePayment(
            UpdatePaymentRequest updatePaymentRequest) throws
            RequestNotValidException,
            UnsupportedPaymentIdentifierException,
            PaymentNotUniqueException,
            PaymentDoesNotExistException;

    class CreatePaymentResponse extends Response
    {
    }
    class CreatePaymentRequest extends Request
    {
        private Payment Payment;

        public Payment getPayment() {
            return Payment;
        }

        public CreatePaymentRequest setPayment(Payment Payment) {
            this.Payment = Payment;
            return this;
        }
    }

    class FindPaymentsResponse extends Response
    {
        private List<Payment> Payments;

        private Long recordCount;

        public List<Payment> getPayments() {
            return Payments;
        }

        public FindPaymentsResponse setPayments(List<Payment> Payments) {
            this.Payments = Payments;
            return this;
        }
    }

    class FindPaymentsRequest extends Request
    {
        private SearchCriteria searchCriteria;

        public SearchCriteria getSearchCriteria()
        {
            return searchCriteria;
        }

        public FindPaymentsRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
    }

    class UpdatePaymentResponse extends Response
    {
    }

    class UpdatePaymentRequest extends Request{

        private Payment Payment;

        private PaymentIdentifier paymentIdentifier;

        public Payment getPayment()
        {
            return Payment;
        }

        public UpdatePaymentRequest setPayment(Payment Payment)
        {
            this.Payment = Payment;
            return this;
        }

        public PaymentIdentifier getPaymentIdentifier()
        {
            return paymentIdentifier;
        }

        public UpdatePaymentRequest setPaymentIdentifier(PaymentIdentifier paymentIdentifier)
        {
            this.paymentIdentifier = paymentIdentifier;
            return this;
        }
    }

    class RemovePaymentResponse extends Response
    {

    }

    class RemovePaymentRequest extends Request
    {
        private PaymentIdentifier PaymentIdentifier;

        public PaymentIdentifier getPaymentIdentifier()
        {
            return PaymentIdentifier;
        }

        public RemovePaymentRequest setPaymentIdentifier(PaymentIdentifier PaymentIdentifier)
        {
            this.PaymentIdentifier = PaymentIdentifier;
            return this;
        }
    }

    class RetrievePaymentResponse extends Response
    {
        private Payment Payment;

        public Payment getPayment() {
            return Payment;
        }

        public RetrievePaymentResponse setPayment(Payment Payment) {
            this.Payment = Payment;
            return this;
        }
    }

    class RetrievePaymentRequest extends Request
    {
        private PaymentIdentifier PaymentIdentifier;

        public PaymentIdentifier getPaymentIdentifier() {
            return PaymentIdentifier;
        }

        public RetrievePaymentRequest setPaymentIdentifier(PaymentIdentifier PaymentIdentifier) {
            this.PaymentIdentifier = PaymentIdentifier;
            return this;
        }
    }

    class PaymentAlreadyExistsException extends PreconditionViolation
    {
        public PaymentAlreadyExistsException() {}

        public PaymentAlreadyExistsException(String message)
        {
            super(message);
        }
    }

    class PaymentDoesNotExistException extends PreconditionViolation
    {
        public PaymentDoesNotExistException() {}

        public PaymentDoesNotExistException(String message)
        {
            super(message);
        }
    }

    class UnsupportedPaymentIdentifierException extends PreconditionViolation
    {

        public UnsupportedPaymentIdentifierException(String message) {
            super(message);
        }

        public UnsupportedPaymentIdentifierException() {}
    }

    class PaymentNotUniqueException extends PreconditionViolation
    {
        public PaymentNotUniqueException() {}

        public PaymentNotUniqueException(String message)
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
