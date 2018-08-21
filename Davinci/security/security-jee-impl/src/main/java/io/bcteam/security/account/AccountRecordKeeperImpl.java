package io.bcteam.security.account;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.person.PersonRecordKeeper;
import io.bcteam.entity.person.identifier.PersonIdentificationNumber;
import io.bcteam.location.geographic.coordinate.Coordinate;
import io.bcteam.search.criteria.AllSearch;
import io.bcteam.security.account.identifier.AccountEmail;
import io.bcteam.security.account.identifier.AccountIdentifier;
import io.bcteam.security.account.identifier.AccountPrincipal;
import io.bcteam.security.account.search.criteria.AccountIdentifierSearch;

import java.util.ArrayList;
import java.util.List;

public class AccountRecordKeeperImpl implements AccountRecordKeeper.AccountRecordKeeperLocal,
        AccountRecordKeeper.AccountRecordKeeperRemote
{

    private PersonRecordKeeper personRecordKeeper;

    @Override
    public CreateAccountResponse createAccount(CreateAccountRequest createAccountRequest) throws
            RequestNotValidException, 
            AccountAlreadyExistsException {

        if (createAccountRequest.getAccount()==null){
            throw new RequestNotValidException("Account must be provided.");
        }

        /**
         * TODO Check if account already exists and throw AccountAlreadyExistsException accordingly.
         */

        /**
         * TODO Persist Account To Database
         */

        return new CreateAccountResponse();
    }

    @Override
    public FindAccountsResponse findAccounts(FindAccountsRequest findAccountsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {

        if (findAccountsRequest.getSearchCriteria() == null){
            throw new RequestNotValidException("AccountSearchCriteria must be provided.");
        }

        if (findAccountsRequest.getSearchCriteria() instanceof AccountIdentifierSearch) {
            if (((AccountIdentifierSearch) findAccountsRequest.getSearchCriteria()).getAccountIdentifier() instanceof AccountEmail){
                throw new RuntimeException("AccountIdentifierSearch not allowed for findAccounts. " +
                        "Use retrieveAccount.");
            }
            else if (((AccountIdentifierSearch) findAccountsRequest.getSearchCriteria()).getAccountIdentifier() instanceof AccountPrincipal){
                throw new RuntimeException("AccountIdentifierSearch not allowed for findAccounts. " +
                        "Use retrieveAccount.");
            }
            else {
                throw new RuntimeException("AccountIdentifierSearch not allowed for findAccounts. " +
                        "Use retrieveAccount.");
            }
        } else if (findAccountsRequest.getSearchCriteria() instanceof AllSearch) {
            /**
             * TODO Find all accounts from database.
             */
        }
        else {
            throw new UnsupportedSearchCriteriaException("Search Criteria is not supported for find accounts.");
        }

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        /**
         *  Account Devices From Database
         */
        List<String> devices = new ArrayList<>();
        devices.add("deviceID");

        List<Account> accounts = new ArrayList<>();
        accounts.add(
                new Account()
                        .setCurrentLocation(new Coordinate().setLatitude(10.00).setLongitude(10.00))
                        .setDevices(devices)
                        .setEmail("email")
                        .setOrganisationName("organisationName")
                        .setPassword("password")
                        .setUserName("Username")
                        .setPerson(new PersonIdentificationNumber().setIdentificationNumber("Id number")));

        /**
         * Above is just mock implementation to get server started without relying on database.
         */
        
        return new FindAccountsResponse().setAccounts(accounts);
    }

    @Override
    public RemoveAccountResponse removeAccount(RemoveAccountRequest removeAccountRequest) throws 
            RequestNotValidException, 
            AccountDoesNotExistException, 
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException {

        if (removeAccountRequest.getAccountIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(removeAccountRequest.getAccountIdentifier() instanceof AccountIdentifier)){
            throw new UnsupportedAccountIdentifierException(
                    "Identifier is not instance of AccountIdentifier.");
        }

        Account account = retrieveAccount(new RetrieveAccountRequest().setAccountIdentifier(removeAccountRequest.getAccountIdentifier())).getAccount();

        /**
         * TODO Remove Account From Database
         */
        
        return new RemoveAccountResponse();
    }

    @Override
    public RetrieveAccountResponse retrieveAccount(RetrieveAccountRequest retrieveAccountRequest) throws
            RequestNotValidException,
            AccountDoesNotExistException,
            AccountNotUniqueException,
            UnsupportedAccountIdentifierException {

        if (retrieveAccountRequest.getAccountIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(retrieveAccountRequest.getAccountIdentifier() instanceof AccountIdentifier)){
            throw new UnsupportedAccountIdentifierException(
                    "Identifier is not instance of AccountIdentifier.");
        }
        /**
         * TODO Retrieve Accounts From Database
         */

        /**
         * TODO Validate that only one account returns otherwise -> AccountNotUniqueException
         */

        /**
         * TODO Validate that at least a account returns -> AccountDoesNotExistException
         */

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        /**
         * TODO Retrieve Account From Database
         */

        /**
         *  Account Devices From Database
         */

        List<String> devices = new ArrayList<>();
        devices.add("deviceID");

        Account account =
                new Account()
                        .setCurrentLocation(new Coordinate().setLatitude(10.00).setLongitude(10.00))
                        .setDevices(devices)
                        .setEmail("email")
                        .setOrganisationName("organisationName")
                        .setPassword("password")
                        .setUserName("Username")
                        .setPerson(new PersonIdentificationNumber().setIdentificationNumber("Id number"));

        /**
         * Above is just mock implementation to get server started without relying on database.
         */

        return new RetrieveAccountResponse().setAccount(account);
    }

    @Override
    public UpdateAccountResponse updateAccount(UpdateAccountRequest updateAccountRequest) throws 
            RequestNotValidException, 
            AccountDoesNotExistException,
            AccountNotUniqueException,
            UnsupportedAccountIdentifierException {

        Account account = updateAccountRequest.getAccount();

        if (account == null || updateAccountRequest.getAccountIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(updateAccountRequest.getAccountIdentifier() instanceof AccountIdentifier)){
            throw new UnsupportedAccountIdentifierException(
                    "Identifier is not instance of AccountIdentifier.");
        }

        Account accountEntity = retrieveAccount(new RetrieveAccountRequest().setAccountIdentifier(updateAccountRequest.getAccountIdentifier())).getAccount();

        /* Update only the fields that may be updated */
        accountEntity.setCurrentLocation(account.getCurrentLocation());
        accountEntity.setDevices(account.getDevices());
        accountEntity.setEmail(account.getEmail());
        accountEntity.setOrganisationName(account.getOrganisationName());
        accountEntity.setUserName(account.getUserName());
        accountEntity.setPassword(account.getPassword());

        return new UpdateAccountResponse();
    }
}
