package io.bcteam.security.account.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.Authenticator.*;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@Path("/security/accounts/authenticate")
@Stateless(name = "AuthenticatorRestRpcAdapter")
@Local(Authenticator.AuthenticatorLocal.class)
public class AuthenticatorImpl implements Authenticator {

    @Inject
    private io.bcteam.security.account.Authenticator authenticator;

    @Override
    @Path("/authenticateCredentials")
    @POST
    @Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    @Produces(MediaType.APPLICATION_JSON)
    public Response authenticateCredentials(AuthenticateCredentialsRequest authenticateCredentialsRequest) throws RequestNotValidException {
        return Response.ok().entity(authenticator.authenticateCredentials(authenticateCredentialsRequest)).build();
    }
}
