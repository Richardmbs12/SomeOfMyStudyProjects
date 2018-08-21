package io.bcteam.logistical.order.identifier;

public class OrderBarcode extends OrderIdentifier{
    private String barcode;

    public String getBarcode() {
        return barcode;
    }

    public OrderBarcode setBarcode(String barcode) {
        this.barcode = barcode;
        return this;
    }
}
