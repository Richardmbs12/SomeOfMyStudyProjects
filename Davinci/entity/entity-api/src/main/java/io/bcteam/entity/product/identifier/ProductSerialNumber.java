package io.bcteam.entity.product.identifier;

public class ProductSerialNumber extends ProductIdentifier{
    private String serialNumber;

    public String getSerialNumber() {
        return serialNumber;
    }

    public ProductSerialNumber setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
        return this;
    }
}
