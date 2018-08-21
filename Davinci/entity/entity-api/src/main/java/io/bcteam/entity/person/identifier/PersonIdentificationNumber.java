package io.bcteam.entity.person.identifier;

public class PersonIdentificationNumber extends PersonIdentifier {
    private String identificationNumber;

    public String getIdentificationNumber() {
        return identificationNumber;
    }

    public PersonIdentificationNumber setIdentificationNumber(String identificationNumber) {
        this.identificationNumber = identificationNumber;
        return this;
    }
}
