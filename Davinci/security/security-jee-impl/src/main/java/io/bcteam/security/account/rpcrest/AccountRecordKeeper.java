package io.bcteam.security.account.rpcrest;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.security.account.AccountRecordKeeper.*;

import javax.ws.rs.core.Response;

public interface AccountRecordKeeper {
    Response createAccount(
            CreateAccountRequest createAccountRequest) throws
            RequestNotValidException,
            AccountAlreadyExistsException;

    Response findAccounts(
            FindAccountsRequest findAccountsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    Response removeAccount(
            RemoveAccountRequest removeAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountDoesNotExistException,
            AccountNotUniqueException;

    Response retrieveAccount(
            RetrieveAccountRequest retrieveAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException,
            AccountDoesNotExistException;

    Response updateAccount(
            UpdateAccountRequest updateAccountRequest) throws
            RequestNotValidException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException,
            AccountDoesNotExistException;

    /** Local interface */
    interface AccountRecordKeeperLocal extends AccountRecordKeeper {}
}
