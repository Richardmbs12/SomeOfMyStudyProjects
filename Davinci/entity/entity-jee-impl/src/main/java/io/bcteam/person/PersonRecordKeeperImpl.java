package io.bcteam.person;


import com.mongodb.*;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.connection.ConnectionDB;
import io.bcteam.entity.person.Person;
import io.bcteam.entity.person.PersonRecordKeeper;
import io.bcteam.entity.person.identifier.PersonIdentificationNumber;
import io.bcteam.entity.person.identifier.PersonIdentifier;
import io.bcteam.entity.person.search.criteria.PersonIdentifierSearch;
import io.bcteam.location.geographic.address.Address;
import io.bcteam.search.criteria.AllSearch;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class PersonRecordKeeperImpl implements PersonRecordKeeper.PersonRecordKeeperLocal,
        PersonRecordKeeper.PersonRecordKeeperRemote
{

    private static final Logger LOGGER = LoggerFactory.getLogger(PersonRecordKeeperImpl.class);

    private DBCollection personCollection = new ConnectionDB().getDatabase().getCollection("Person");
    @Override
    public CreatePersonResponse createPerson(CreatePersonRequest createPersonRequest) throws
            RequestNotValidException,
            PersonAlreadyExistsException {

        Person person = createPersonRequest.getPerson();
        if (createPersonRequest.getPerson()==null){
            throw new RequestNotValidException("Person must be provided.");
        }

        /**
         * TODO Check if person already exists and throw PersonlreadyExistsException accordingly.
         */
        DBObject personEntity = new BasicDBObject()
                .append("id",person.getIdentificationNumber())
                .append("firstName",person.getFirstNames())
                .append("lastName",person.getLastName())
                .append("gender",person.getGender())
                .append("dateOfBirth",person.getDateOfBirth())
                .append("contactNumber",person.getContactNumber())
                .append("address", new BasicDBObject("addressLineOne",person.getAddress().getAddressLineOne())
                        .append("addressLineTwo",person.getAddress().getAddressLineTwo())
                        .append("city",person.getAddress().getCity())
                        .append("suburb",person.getAddress().getSuburb()));


        personCollection.insert(personEntity);


        /**
         * TODO Persist Person To Database
         */


        return new CreatePersonResponse();
    }

    @Override
    public FindPersonsResponse findPersons(FindPersonsRequest findPersonsRequest) throws 
            RequestNotValidException,
            UnsupportedSearchCriteriaException {

        if (findPersonsRequest.getSearchCriteria() == null){
            throw new RequestNotValidException("PersonSearchCriteria must be provided.");
        }

        List<Person> people = new ArrayList<>();
        if (findPersonsRequest.getSearchCriteria() instanceof PersonIdentifierSearch) {
            if (((PersonIdentifierSearch) findPersonsRequest.getSearchCriteria()).getPersonIdentifier() instanceof PersonIdentificationNumber){
                throw new RuntimeException("PersonIdentificationNumber not allowed for findPersons. " +
                        "Use retrievePerson.");
            }
            else {
                throw new RuntimeException("PersonIdentifierSearch not allowed for findPersons. " +
                        "Use retrievePerson.");
            }
        } else if (findPersonsRequest.getSearchCriteria() instanceof AllSearch) {

            DBCursor cursor = personCollection.find();
            while (cursor.hasNext()) {
                DBObject theObj = cursor.next();
                BasicDBList personList = (BasicDBList) theObj.get("people");
                for (int i = 0; i < personList.size(); i++) {
                    BasicDBObject studentObj = (BasicDBObject) personList.get(i);
                    Person person = new Person()
                            .setIdentificationNumber(studentObj.getString("id"))
                            .setFirstNames(studentObj.getString("firstName"))
                            .setLastName(studentObj.getString("lastName"))
                            .setGender(studentObj.getString("gender"))
                            .setDateOfBirth(LocalDateTime.parse(studentObj.getString("dateOfBirth")))
                            .setContactNumber(studentObj.getString("contactNumber"))
                            .setAddress(new Address()
                                    .setAddressLineOne(studentObj.getString("address.addressLineOne"))
                                    .setAddressLineTwo(studentObj.getString("address.addressLineTwo"))
                                    .setCity(studentObj.getString("address.city"))
                                    .setSuburb(studentObj.getString("address.suburb")));



                    people.add(person);
                }
            }

            /**
             * TODO Find all persons from database.
             */


        }
        else {
            throw new UnsupportedSearchCriteriaException("Search Criteria is not supported for find orders.");
        }

        /**
         * Below is just mock implementation to get server started without relying on database.
         */
        return new FindPersonsResponse().setPersons(people);
    }

    @Override
    public RemovePersonResponse removePerson(RemovePersonRequest removePersonRequest) throws 
            RequestNotValidException, 
            UnsupportedPersonIdentifierException, 
            PersonDoesNotExistException, 
            PersonNotUniqueException {


        if (removePersonRequest.getPersonIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(removePersonRequest.getPersonIdentifier() instanceof PersonIdentifier)){
            throw new UnsupportedPersonIdentifierException(
                    "Identifier is not instance of PersonIdentifier.");
        }

        Person person = retrievePerson(new RetrievePersonRequest().setPersonIdentifier(removePersonRequest.getPersonIdentifier())).getPerson();

        /**
         * TODO remove Person from Database
         */

        return new RemovePersonResponse();
    }

    @Override
    public RetrievePersonResponse retrievePerson(RetrievePersonRequest retrievePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException {


        if (retrievePersonRequest.getPersonIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(retrievePersonRequest.getPersonIdentifier() instanceof PersonIdentifier)){
            throw new UnsupportedPersonIdentifierException(
                    "Identifier is not instance of PersonIdentifier.");
        }
        /**
         * TODO Retrieve Person From Database
         */

        /**
         * TODO Validate that only one Person returns otherwise -> PersonNotUniqueException
         */

        /**
         * TODO Validate that at least a Person returns -> PersonDoesNotExistException
         */

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        /**
         * TODO Retrieve Person From Database
         */

        Person person = new Person()
                        .setAddress(
                                new Address()
                                        .setAddressLineOne("AddressLineOne")
                                        .setAddressLineTwo("AddressLineTwo")
                                        .setCity("City")
                                        .setSuburb("Suburb"))
                        .setContactNumber("ContactNumber")
                        .setDateOfBirth(LocalDateTime.now())
                        .setFirstNames("FirstNames")
                        .setGender("Gender")
                        .setIdentificationNumber("12344124213")
                        .setLastName("LastName");

        /**
         * Above is just mock implementation to get server started without relying on database.
         */

        return new RetrievePersonResponse().setPerson(person);
    }

    @Override
    public UpdatePersonResponse updatePerson(UpdatePersonRequest updatePersonRequest) throws 
            RequestNotValidException, 
            UnsupportedPersonIdentifierException, 
            PersonNotUniqueException, 
            PersonDoesNotExistException {

        Person person = updatePersonRequest.getPerson();

        if (person == null || updatePersonRequest.getPersonIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(updatePersonRequest.getPersonIdentifier() instanceof PersonIdentifier)){
            throw new UnsupportedPersonIdentifierException(
                    "Identifier is not instance of PersonIdentifier.");
        }

        Person personEntity = retrievePerson(new RetrievePersonRequest().setPersonIdentifier(updatePersonRequest.getPersonIdentifier())).getPerson();

        /* Update only the fields that may be updated */
        personEntity.setAddress(person.getAddress());
        personEntity.setContactNumber(person.getContactNumber());
        personEntity.setLastName(person.getLastName());

        /**
         * TODO Update Person to Database
         */

        return new UpdatePersonResponse();
    }
}
