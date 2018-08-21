package io.bcteam.financial.payment;

import java.io.Serializable;
import java.time.LocalDateTime;

public class Payment implements Serializable {
    private PaymentMethod method;
    private LocalDateTime date;
    private Double amount;
    private String uuId;

    public String getUuId() {
        return uuId;
    }

    public Payment setUuId(String uuId) {
        this.uuId = uuId;
        return this;
    }

    public PaymentMethod getMethod() {
        return method;
    }

    public Payment setMethod(PaymentMethod method) {
        this.method = method;
        return this;
    }

    public LocalDateTime getDate() {
        return date;
    }

    public Payment setDate(LocalDateTime date) {
        this.date = date;
        return this;
    }

    public Double getAmount() {
        return amount;
    }

    public Payment setAmount(Double amount) {
        this.amount = amount;
        return this;
    }
}

