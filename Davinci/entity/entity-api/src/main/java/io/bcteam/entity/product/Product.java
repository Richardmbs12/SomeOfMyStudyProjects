package io.bcteam.entity.product;

import java.io.Serializable;

public class Product implements Serializable {
    private String serial;
    private String name;
    private String description;
    private Double price;
    private Integer stockAvailable;

    public String getSerial() {
        return serial;
    }

    public Product setSerial(String serial) {
        this.serial = serial;
        return this;
    }

    public String getName() {
        return name;
    }

    public Product setName(String name) {
        this.name = name;
        return this;
    }

    public String getDescription() {
        return description;
    }

    public Product setDescription(String description) {
        this.description = description;
        return this;
    }

    public Double getPrice() {
        return price;
    }

    public Product setPrice(Double price) {
        this.price = price;
        return this;
    }

    public Integer getStockAvailable() {
        return stockAvailable;
    }

    public Product setStockAvailable(Integer stockAvailable) {
        this.stockAvailable = stockAvailable;
        return this;
    }
}
