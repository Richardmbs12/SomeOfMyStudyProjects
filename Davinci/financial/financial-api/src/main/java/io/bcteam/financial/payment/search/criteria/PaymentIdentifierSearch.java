package io.bcteam.financial.payment.search.criteria;

import io.bcteam.financial.payment.identifier.PaymentIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

public class PaymentIdentifierSearch extends SearchCriteria {
    private PaymentIdentifier paymentIdentifier;

    public PaymentIdentifier getNaturalPaymentIdentifier()
    {
        return paymentIdentifier;
    }

    public PaymentIdentifierSearch setNaturalPaymentIdentifier(PaymentIdentifier personIdentifier)
    {
        this.paymentIdentifier = paymentIdentifier;
        return this;
    }
}
