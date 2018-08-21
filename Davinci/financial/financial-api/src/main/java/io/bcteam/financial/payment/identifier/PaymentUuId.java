package io.bcteam.financial.payment.identifier;

public class PaymentUuId extends PaymentIdentifier {
    private String uuId;

    public String getUuId() {
        return uuId;
    }

    public PaymentUuId setUuId(String uuId) {
        this.uuId = uuId;
        return this;
    }
}
