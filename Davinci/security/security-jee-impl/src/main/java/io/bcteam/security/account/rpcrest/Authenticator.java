package io.bcteam.security.account.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.Authenticator.*;

import javax.ws.rs.core.Response;

public interface Authenticator {
    Response authenticateCredentials(AuthenticateCredentialsRequest authenticateCredentialsRequest) throws
            RequestNotValidException;

    /** Local interface */
    interface AuthenticatorLocal extends Authenticator {}
}
