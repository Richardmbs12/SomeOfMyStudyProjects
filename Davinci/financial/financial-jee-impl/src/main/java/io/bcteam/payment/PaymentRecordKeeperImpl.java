package io.bcteam.payment;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.financial.payment.Payment;
import io.bcteam.financial.payment.PaymentMethod;
import io.bcteam.financial.payment.PaymentRecordKeeper;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class PaymentRecordKeeperImpl implements PaymentRecordKeeper {
    @Override
    public CreatePaymentResponse createPayment(CreatePaymentRequest createPaymentRequest) throws RequestNotValidException, PaymentAlreadyExistsException {
        /**
         * TODO Persist Payment To Database
         */

        return new CreatePaymentResponse();
    }

    @Override
    public FindPaymentsResponse findPayments(FindPaymentsRequest findPaymentsRequest) throws RequestNotValidException, UnsupportedSearchCriteriaException {
        /**
         * TODO Find Payments From Database
         */
        List<Payment> payments = new ArrayList<>();
        payments.add(
                new Payment()
                        .setAmount(100.00)
                        .setDate(LocalDateTime.now())
                        .setMethod(PaymentMethod.CASH)
                        .setUuId(UUID.randomUUID().toString()));
        return new FindPaymentsResponse().setPayments(payments);
    }

    @Override
    public RemovePaymentResponse removePayment(RemovePaymentRequest removePaymentRequest) throws RequestNotValidException, UnsupportedPaymentIdentifierException, PaymentDoesNotExistException, PaymentNotUniqueException {
        /**
         * TODO Remove Payment From Database
         */
        return new RemovePaymentResponse();
    }

    @Override
    public RetrievePaymentResponse retrievePayment(RetrievePaymentRequest retrievePaymentRequest) throws RequestNotValidException, UnsupportedPaymentIdentifierException, PaymentNotUniqueException, PaymentDoesNotExistException {
        /**
         * TODO Retrieve Payment From Database
         */
        Payment payment = new Payment()
                .setAmount(100.00)
                .setDate(LocalDateTime.now())
                .setMethod(PaymentMethod.CASH)
                .setUuId(UUID.randomUUID().toString());
        return new RetrievePaymentResponse().setPayment(payment);
    }

    @Override
    public UpdatePaymentResponse updatePayment(UpdatePaymentRequest updatePaymentRequest) throws RequestNotValidException, UnsupportedPaymentIdentifierException, PaymentNotUniqueException, PaymentDoesNotExistException {
        /**
         * TODO Update Payment to Database
         */
        return new UpdatePaymentResponse();
    }
}
