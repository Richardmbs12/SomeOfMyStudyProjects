package io.bcteam.entity.person;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.person.identifier.PersonIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

import java.util.List;

public interface PersonRecordKeeper {
    CreatePersonResponse createPerson(
            CreatePersonRequest createPersonRequest) throws
            RequestNotValidException,
            PersonAlreadyExistsException;

    FindPersonsResponse findPersons(
            FindPersonsRequest findPersonsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    RemovePersonResponse removePerson(
            RemovePersonRequest removePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonDoesNotExistException,
            PersonNotUniqueException;

    RetrievePersonResponse retrievePerson(
            RetrievePersonRequest retrievePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException;

    UpdatePersonResponse updatePerson(
            UpdatePersonRequest updatePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException;
    
    class CreatePersonResponse extends Response
    {
    }
    class CreatePersonRequest extends Request
    {
        private Person Person;

        public Person getPerson() {
            return Person;
        }

        public CreatePersonRequest setPerson(Person Person) {
            this.Person = Person;
            return this;
        }
    }
    
    class FindPersonsResponse extends Response
    {
        private List<Person> Persons;

        private Long recordCount;

        public List<Person> getPersons() {
            return Persons;
        }

        public FindPersonsResponse setPersons(List<Person> Persons) {
            this.Persons = Persons;
            return this;
        }
    }
    
    class FindPersonsRequest extends Request
    {
        private SearchCriteria searchCriteria;

        public SearchCriteria getSearchCriteria()
        {
            return searchCriteria;
        }

        public FindPersonsRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
    }
    
    class UpdatePersonResponse extends Response
    {
    }
    
    class UpdatePersonRequest extends Request{

        private Person Person;

        private PersonIdentifier personIdentifier;

        public Person getPerson()
        {
            return Person;
        }

        public UpdatePersonRequest setPerson(Person Person)
        {
            this.Person = Person;
            return this;
        }

        public PersonIdentifier getPersonIdentifier()
        {
            return personIdentifier;
        }

        public UpdatePersonRequest setPersonIdentifier(PersonIdentifier personIdentifier)
        {
            this.personIdentifier = personIdentifier;
            return this;
        }
    }
    
    class RemovePersonResponse extends Response
    {

    }
    
    class RemovePersonRequest extends Request
    {
        private PersonIdentifier PersonIdentifier;

        public PersonIdentifier getPersonIdentifier()
        {
            return PersonIdentifier;
        }

        public RemovePersonRequest setPersonIdentifier(PersonIdentifier PersonIdentifier)
        {
            this.PersonIdentifier = PersonIdentifier;
            return this;
        }
    }
    
    class RetrievePersonResponse extends Response
    {
        private Person Person;

        public Person getPerson() {
            return Person;
        }

        public RetrievePersonResponse setPerson(Person Person) {
            this.Person = Person;
            return this;
        }
    }
    
    class RetrievePersonRequest extends Request
    {
        private PersonIdentifier PersonIdentifier;

        public PersonIdentifier getPersonIdentifier() {
            return PersonIdentifier;
        }

        public RetrievePersonRequest setPersonIdentifier(PersonIdentifier PersonIdentifier) {
            this.PersonIdentifier = PersonIdentifier;
            return this;
        }
    }
    
    class PersonAlreadyExistsException extends PreconditionViolation
    {
        public PersonAlreadyExistsException() {}

        public PersonAlreadyExistsException(String message)
        {
            super(message);
        }
    }

    class PersonDoesNotExistException extends PreconditionViolation
    {
        public PersonDoesNotExistException() {}

        public PersonDoesNotExistException(String message)
        {
            super(message);
        }
    }
    
    class UnsupportedPersonIdentifierException extends PreconditionViolation
    {

        public UnsupportedPersonIdentifierException(String message) {
            super(message);
        }

        public UnsupportedPersonIdentifierException() {}
    }
    
    class PersonNotUniqueException extends PreconditionViolation
    {
        public PersonNotUniqueException() {}

        public PersonNotUniqueException(String message)
        {
            super(message);
        }
    }
    
    class UnsupportedSearchCriteriaException extends PreconditionViolation
    {
        public UnsupportedSearchCriteriaException() {}

        public UnsupportedSearchCriteriaException(String message)
        {
            super(message);
        }
    }
}
