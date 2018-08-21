package io.bcteam.security.account.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.AccountRecordKeeper.*;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@Path("/security/accounts/")
@Stateless(name = "AccountRecordKeeperRestRpcAdapter")
@Local(AccountRecordKeeper.AccountRecordKeeperLocal.class)
public class AccountRecordKeeperImpl implements AccountRecordKeeper{

    @Inject
    private io.bcteam.security.account.AccountRecordKeeper accountRecordKeeper;

    @Override
    @Path("/createaccount")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response createAccount(CreateAccountRequest createAccountRequest) throws
            RequestNotValidException,
            AccountAlreadyExistsException {
        return Response.ok().entity(accountRecordKeeper.createAccount(createAccountRequest)).build();
    }

    @Override
    @Path("/findpeople")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response findAccounts(FindAccountsRequest findAccountsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {
        return Response.ok().entity(accountRecordKeeper.findAccounts(findAccountsRequest)).build();
    }

    @Override
    @Path("/removeaccount")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response removeAccount(RemoveAccountRequest removeAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountDoesNotExistException,
            AccountNotUniqueException {
        return Response.ok().entity(accountRecordKeeper.removeAccount(removeAccountRequest)).build();
    }

    @Override
    @Path("/retrieveaccount")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response retrieveAccount(RetrieveAccountRequest retrieveAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException,
            AccountDoesNotExistException {
        return Response.ok().entity(accountRecordKeeper.retrieveAccount(retrieveAccountRequest)).build();
    }

    @Override
    @Path("/updateaccount")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response updateAccount(UpdateAccountRequest updateAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException,
            AccountDoesNotExistException {
        return Response.ok().entity(accountRecordKeeper.updateAccount(updateAccountRequest)).build();
    }
}
