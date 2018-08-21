package io.bcteam.person.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import io.bcteam.entity.person.PersonRecordKeeper.*;

@Path("/persons")
@Stateless(name = "PersonRecordKeeperRestRpcAdapter")
@Local(PersonRecordKeeper.PersonRecordKeeperLocal.class)
public class PersonRecordKeeperImpl implements PersonRecordKeeper{

    @Inject
    private io.bcteam.entity.person.PersonRecordKeeper personRecordKeeper;

    @Override
    @Path("/createperson")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response createPerson(CreatePersonRequest createPersonRequest) throws
            RequestNotValidException,
            PersonAlreadyExistsException {
        return Response.ok().entity(personRecordKeeper.createPerson(createPersonRequest)).build();
    }

    @Override
    @Path("/findpeople")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response findPersons(FindPersonsRequest findPersonsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {
        return Response.ok().entity(personRecordKeeper.findPersons(findPersonsRequest)).build();
    }

    @Override
    @Path("/removeperson")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response removePerson(RemovePersonRequest removePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonDoesNotExistException,
            PersonNotUniqueException {
        return Response.ok().entity(personRecordKeeper.removePerson(removePersonRequest)).build();
    }

    @Override
    @Path("/retrieveperson")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response retrievePerson(RetrievePersonRequest retrievePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException {
        return Response.ok().entity(personRecordKeeper.retrievePerson(retrievePersonRequest)).build();
    }

    @Override
    @Path("/updateperson")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response updatePerson(UpdatePersonRequest updatePersonRequest) throws
            RequestNotValidException,
            UnsupportedPersonIdentifierException,
            PersonNotUniqueException,
            PersonDoesNotExistException {
        return Response.ok().entity(personRecordKeeper.updatePerson(updatePersonRequest)).build();
    }
}
