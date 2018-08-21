package io.bcteam.location.geographic.address;

import java.io.Serializable;

public class Address implements Serializable {
    private String addressLineOne;
    private String addressLineTwo;
    private String suburb;
    private String city;

    public String getAddressLineOne() {
        return addressLineOne;
    }

    public Address setAddressLineOne(String addressLineOne) {
        this.addressLineOne = addressLineOne;
        return this;
    }

    public String getAddressLineTwo() {
        return addressLineTwo;
    }

    public Address setAddressLineTwo(String addressLineTwo) {
        this.addressLineTwo = addressLineTwo;
        return this;
    }

    public String getSuburb() {
        return suburb;
    }

    public Address setSuburb(String suburb) {
        this.suburb = suburb;
        return this;
    }

    public String getCity() {
        return city;
    }

    public Address setCity(String city) {
        this.city = city;
        return this;
    }
}
