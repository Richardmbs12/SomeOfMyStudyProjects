package io.bcteam.entity.product.identifier;

public class ProductOrderNumber extends ProductIdentifier{
    private String orderID;

    public String getOrderID() {
        return orderID;
    }

    public ProductOrderNumber setOrderID(String orderID) {
        this.orderID = orderID;
        return this;
    }
}
