package io.bcteam.logistical.order;

import io.bcteam.financial.payment.Payment;
import io.bcteam.security.account.identifier.AccountIdentifier;

import java.io.Serializable;
import java.util.List;

public class Order implements Serializable {
    private List<String> products;
    private Double totalPrice;
    private Payment payment;
    private String barcode;
    private boolean claimed;
    private AccountIdentifier account;

    public AccountIdentifier getAccount() {
        return account;
    }

    public Order setAccount(AccountIdentifier account) {
        this.account = account
        ;return this;
    }

    public boolean isClaimed() {
        return claimed;
    }

    public Order setClaimed(boolean claimed) {
        this.claimed = claimed;
        return this;
    }

    public String getBarcode() {
        return barcode;
    }

    public Order setBarcode(String barcode) {
        this.barcode = barcode;
        return this;
    }

    public List<String> getProducts() {
        return products;
    }

    public Order setProducts(List<String> products) {
        this.products = products;
        return this;
    }

    public Double getTotalPrice() {
        return totalPrice;
    }

    public Order setTotalPrice(Double totalPrice) {
        this.totalPrice = totalPrice;
        return this;
    }

    public Payment getPayment() {
        return payment;
    }

    public Order setPayment(Payment paymentMethod) {
        this.payment = payment;
        return this;
    }
}
