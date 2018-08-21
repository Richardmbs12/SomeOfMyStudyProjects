package io.bcteam.entity.person;

import io.bcteam.location.geographic.address.Address;

import java.io.Serializable;
import java.time.LocalDateTime;

public class Person implements Serializable {
    private String firstNames;
    private String lastName;
    private String Gender;
    private Address address;
    private String identificationNumber;
    private String contactNumber;
    private LocalDateTime dateOfBirth;

    public String getContactNumber() {
        return contactNumber;
    }

    public Person setContactNumber(String contactNumber) {
        this.contactNumber = contactNumber;
        return this;
    }

    public String getFirstNames() {
        return firstNames;
    }

    public Person setFirstNames(String firstNames) {
        this.firstNames = firstNames;
        return this;
    }

    public String getLastName() {
        return lastName;
    }

    public Person setLastName(String lastName) {
        this.lastName = lastName;
        return this;
    }

    public String getGender() {
        return Gender;
    }

    public Person setGender(String gender) {
        Gender = gender;
        return this;
    }

    public Address getAddress() {
        return address;
    }

    public Person setAddress(Address address) {
        this.address = address;
        return this;
    }

    public String getIdentificationNumber() {
        return identificationNumber;
    }

    public Person setIdentificationNumber(String identificationNumber) {
        this.identificationNumber = identificationNumber;
        return this;
    }

    public LocalDateTime getDateOfBirth() {
        return dateOfBirth;
    }

    public Person setDateOfBirth(LocalDateTime dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
        return this;
    }
}
