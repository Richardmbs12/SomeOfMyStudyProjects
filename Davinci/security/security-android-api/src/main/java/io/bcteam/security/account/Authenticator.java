package io.bcteam.security.account;

import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.credentials.Credentials;

import java.util.concurrent.Future;

public interface Authenticator {
    /** Determines whether the specific credentials are authentic. */
    AuthenticateCredentialsResponse authenticateCredentials(AuthenticateCredentialsRequest authenticateCredentialsRequest) throws
            RequestNotValidException;

    class AuthenticateCredentialsRequest extends Request
    {
        private Credentials credentials;

        /** The credentials that must be authenticated. */
        public Credentials getCredentials()
        {
            return credentials;
        }

        public void setCredentials(Credentials credentials)
        {
            this.credentials = credentials;
        }


    }

    class AuthenticateCredentialsResponse extends Response
    {
        private boolean authentic;

        public boolean getAuthenticationAdvice()
        {
            return authentic;
        }

        public AuthenticateCredentialsResponse setAuthenticationAdvice(boolean authentic)
        {
            this.authentic = authentic;
            return this;
        }

    }
}
