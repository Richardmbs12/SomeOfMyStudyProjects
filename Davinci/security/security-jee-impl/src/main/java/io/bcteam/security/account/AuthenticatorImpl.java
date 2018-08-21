package io.bcteam.security.account;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.Account;
import io.bcteam.security.account.AccountRecordKeeper;
import io.bcteam.security.account.Authenticator;
import io.bcteam.security.account.credentials.PlainTextUsernameAndPassword;
import io.bcteam.security.account.identifier.AccountPrincipal;

public class AuthenticatorImpl implements Authenticator.AuthenticatorLocal,
        Authenticator.AuthenticatorRemote
{

    private AccountRecordKeeper accountRecordKeeper;

    @Override
    public AuthenticateCredentialsResponse authenticateCredentials(AuthenticateCredentialsRequest authenticateCredentialsRequest) throws
            RequestNotValidException {

        if (!(authenticateCredentialsRequest.getCredentials() instanceof PlainTextUsernameAndPassword)) {
            throw new RequestNotValidException("The credential format is not supported.");
        }
        PlainTextUsernameAndPassword credentials = (PlainTextUsernameAndPassword) authenticateCredentialsRequest.getCredentials();

        Account account;
        try {
            account = accountRecordKeeper.retrieveAccount(new AccountRecordKeeper.RetrieveAccountRequest().setAccountIdentifier(
                    new AccountPrincipal().setUserNameString((credentials.getUsername())))).getAccount();
            if (!account.getPassword().equals(credentials.getPassword())){
                return new AuthenticateCredentialsResponse().setAuthenticationAdvice(false);
            }
        } catch (AccountRecordKeeper.AccountDoesNotExistException e) {
            return new AuthenticateCredentialsResponse().setAuthenticationAdvice(false);
        } catch (AccountRecordKeeper.AccountNotUniqueException e) {
            e.printStackTrace();
        } catch (AccountRecordKeeper.UnsupportedAccountIdentifierException e) {
            e.printStackTrace();
        }
        return new AuthenticateCredentialsResponse().setAuthenticationAdvice(true);
    }
}
