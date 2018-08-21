package io.bcteam.person.rpcrest;

import javax.ws.rs.core.Response;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.person.PersonRecordKeeper.*;

public interface PersonRecordKeeper {
    Response createPerson(
            CreatePersonRequest createPersonRequest) throws
            RequestNotValidException,
            PersonAlreadyExistsException;

    Response findPersons(
            FindPersonsRequest findPersonsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    Response removePerson(
            RemovePersonRequest removePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonDoesNotExistException,
            PersonNotUniqueException;

    Response retrievePerson(
            RetrievePersonRequest retrievePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException;

    Response updatePerson(
            UpdatePersonRequest updatePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException;
    /** Local interface */
    interface PersonRecordKeeperLocal extends PersonRecordKeeper {}
}
