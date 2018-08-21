package io.bcteam.entity.product.identifier;

public class ProductName extends ProductIdentifier{
    private String productName;

    public String getProductName() {
        return productName;
    }

    public ProductName setProductName(String productName) {
        this.productName = productName;
        return this;
    }
}
