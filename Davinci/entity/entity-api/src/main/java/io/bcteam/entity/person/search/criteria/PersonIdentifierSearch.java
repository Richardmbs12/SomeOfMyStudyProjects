package io.bcteam.entity.person.search.criteria;

import io.bcteam.entity.person.identifier.PersonIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

public class PersonIdentifierSearch extends SearchCriteria {
    private PersonIdentifier personIdentifier;

    public PersonIdentifier getPersonIdentifier()
    {
        return personIdentifier;
    }

    public PersonIdentifierSearch setPersonIdentifier(PersonIdentifier personIdentifier)
    {
        this.personIdentifier = personIdentifier;
        return this;
    }
}
