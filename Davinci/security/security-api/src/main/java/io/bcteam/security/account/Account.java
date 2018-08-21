package io.bcteam.security.account;

import java.io.Serializable;
import java.util.List;

import io.bcteam.entity.person.identifier.PersonIdentifier;
import io.bcteam.location.geographic.coordinate.Coordinate;

public class Account implements Serializable {
    private String userName;
    private String password;
    private String email;
    private String organisationName;
    private List<String> devices;
    private Coordinate currentLocation;
    private PersonIdentifier person;

    public PersonIdentifier getPerson() {
        return person;
    }

    public Account setPerson(PersonIdentifier person) {
        this.person = person;
        return this;
    }

    public List<String> getDevices() {
        return devices;
    }

    public Account setDevices(List<String> devices) {
        this.devices = devices;
        return this;
    }

    public Coordinate getCurrentLocation() {
        return currentLocation;
    }

    public Account setCurrentLocation(Coordinate currentLocation) {
        this.currentLocation = currentLocation;
        return this;
    }

    public String getOrganisationName() {
        return organisationName;
    }

    public Account setOrganisationName(String organisationName) {
        this.organisationName = organisationName;
        return this;
    }

    public String getUserName() {
        return userName;
    }

    public Account setUserName(String userName) {
        this.userName = userName;
        return this;
    }

    public String getPassword() {
        return password;
    }

    public Account setPassword(String password) {
        this.password = password;
        return this;
    }

    public String getEmail() {
        return email;
    }

    public Account setEmail(String email) {
        this.email = email;
        return this;
    }
}
