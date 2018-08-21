package io.bcteam.security.account;

import io.bcteam.base.preconditionViolation.PreconditionViolation;
import io.bcteam.base.Request;
import io.bcteam.base.Response;
import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.person.Person;
import io.bcteam.search.criteria.SearchCriteria;
import io.bcteam.security.account.identifier.AccountIdentifier;
import java.util.List;

public interface AccountRecordKeeper {

    CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest) throws
            RequestNotValidException,
            AccountAlreadyExistsException;

    FindAccountsResponse findAccounts(FindAccountsRequest findAccountsRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException;

    RemoveAccountResponse removeAccount(RemoveAccountRequest removeAccountRequest) throws
            RequestNotValidException,
            AccountDoesNotExistException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException;

    RetrieveAccountResponse retrieveAccount(RetrieveAccountRequest retrieveAccountRequest) throws
            RequestNotValidException,
            AccountDoesNotExistException,
            AccountNotUniqueException,
            UnsupportedAccountIdentifierException;


    UpdateAccountResponse updateAccount(UpdateAccountRequest updateAccountRequest) throws
            RequestNotValidException,
            AccountDoesNotExistException,
            UnsupportedAccountIdentifierException,
            AccountNotUniqueException;

    class FindAccountsResponse extends Response
    {
        private List<Account> accounts;

        public List<Account> getAccounts() {
            return accounts;
        }

        public FindAccountsResponse setAccounts(List<Account> accounts) {
            this.accounts = accounts;
            return this;
        }
    }

    class FindAccountsRequest extends Request
    {
        private SearchCriteria searchCriteria;

        public SearchCriteria getSearchCriteria() {
            return searchCriteria;
        }

        public FindAccountsRequest setSearchCriteria(SearchCriteria searchCriteria) {
            this.searchCriteria = searchCriteria;
            return this;
        }
    }

    class CreateAccountResponse extends Response
    {
        private Long entityId;

        public Long getEntityId()
        {
            return entityId;
        }

        public CreateAccountResponse setEntityId(Long entityId)
        {
            this.entityId = entityId;
            return this;
        }
    }

    class CreateAccountRequest extends Request
    {
        private Account account;
        private Person person;

        public Person getPerson() {
            return person;
        }

        public CreateAccountRequest setPerson(Person person) {
            this.person = person;
            return this;
        }

        public Account getAccount() {
            return account;
        }

        public CreateAccountRequest setAccount(Account account) {
            this.account = account;
            return this;
        }
    }

    class UpdateAccountResponse extends Response
    {
    }

    class UpdateAccountRequest extends Request
    {

        private Account account;

        private AccountIdentifier accountIdentifier;

        public AccountIdentifier getAccountIdentifier()
        {
            return accountIdentifier;
        }

        public UpdateAccountRequest setAccountIdentifier(AccountIdentifier accountIdentifier)
        {
            this.accountIdentifier = accountIdentifier;
            return this;
        }

        public Account getAccount() {
            return account;
        }

        public UpdateAccountRequest setAccount(Account account) {
            this.account = account;
            return this;
        }

    }


    class RemoveAccountResponse extends Response
    {

    }

    class RemoveAccountRequest extends Request
    {
        private AccountIdentifier accountIdentifier;

        public AccountIdentifier getAccountIdentifier() {
            return accountIdentifier;
        }

        public RemoveAccountRequest setAccountIdentifier(AccountIdentifier accountIdentifier) {
            this.accountIdentifier = accountIdentifier;
            return this;
        }
    }

    class RetrieveAccountResponse extends Response
    {

        private Account account;

        public Account getAccount() {
            return account;
        }

        public RetrieveAccountResponse setAccount(Account account) {
            this.account = account;
            return this;
        }

    }

    class RetrieveAccountRequest extends Request
    {
        private AccountIdentifier accountIdentifier;

        public AccountIdentifier getAccountIdentifier() {
            return accountIdentifier;
        }

        public RetrieveAccountRequest setAccountIdentifier(AccountIdentifier accountIdentifier) {
            this.accountIdentifier = accountIdentifier;
            return this;
        }

    }

    class ChangePasswordResponse extends Response
    {

    }

    class ChangePasswordRequest extends Request
    {
        private AccountIdentifier accountIdentifier;

        private String newPassword;

        public String getNewPassword()
        {
            return newPassword;
        }

        public ChangePasswordRequest setNewPassword(String newPassword)
        {
            this.newPassword = newPassword;
            return this;
        }

        public AccountIdentifier getAccountIdentifier() {
            return accountIdentifier;
        }

        public ChangePasswordRequest setAccountIdentifier(AccountIdentifier accountIdentifier) {
            this.accountIdentifier = accountIdentifier;
            return this;
        }

    }

    /* Pre-Conditions */
    class AccountAlreadyExistsException extends PreconditionViolation
    {

        /** Default constructor. */
        public AccountAlreadyExistsException(){}

        /**
         * Constructs a new <code>AccountAlreadyExistsException</code> exception with the specified detail message.
         *
         * @param message the detail message.
         */
        public AccountAlreadyExistsException(String message)
        {
            super(message);
        }

        /**
         * Constructs a new <code>AccountAlreadyExistsException</code> exception with the specified detail message
         * and cause.
         *
         * @param message the detail message.
         * @param cause the cause.
         */
        public AccountAlreadyExistsException(String message, Throwable cause)
        {
            super(message, cause);
        }

        /**
         * Constructs a new <code>AccountAlreadyExistsException</code> exception with the specified cause.
         *
         * @param cause the cause.
         */
        public AccountAlreadyExistsException(Throwable cause)
        {
            super(cause);
        }

    }

    class AccountDoesNotExistException extends PreconditionViolation
    {

        /** Default constructor. */
        public AccountDoesNotExistException(){}

        /**
         * Constructs a new <code>AccountDoesNotExistException</code> exception with the specified detail message.
         *
         * @param message the detail message.
         */
        public AccountDoesNotExistException(String message)
        {
            super(message);
        }

        /**
         * Constructs a new <code>AccountDoesNotExistException</code> exception with the specified detail message
         * and cause.
         *
         * @param message the detail message.
         * @param cause the cause.
         */
        public AccountDoesNotExistException(String message, Throwable cause)
        {
            super(message, cause);
        }

        /**
         * Constructs a new <code>AccountDoesNotExistException</code> exception with the specified cause.
         *
         * @param cause the cause.
         */
        public AccountDoesNotExistException(Throwable cause)
        {
            super(cause);
        }

    }

    class UnsupportedAccountIdentifierException extends PreconditionViolation
    {

        /** Default constructor. */
        public UnsupportedAccountIdentifierException(){}

        /**
         * Constructs a new <code>UnsupportedAccountIdentifierException</code> exception with the specified detail message.
         *
         * @param message the detail message.
         */
        public UnsupportedAccountIdentifierException(String message)
        {
            super(message);
        }

        /**
         * Constructs a new <code>UnsupportedAccountIdentifierException</code> exception with the specified detail message
         * and cause.
         *
         * @param message the detail message.
         * @param cause the cause.
         */
        public UnsupportedAccountIdentifierException(String message, Throwable cause)
        {
            super(message, cause);
        }

        /**
         * Constructs a new <code>UnsupportedAccountIdentifierException</code> exception with the specified cause.
         *
         * @param cause the cause.
         */
        public UnsupportedAccountIdentifierException(Throwable cause)
        {
            super(cause);
        }

    }

    class AccountNotUniqueException extends PreconditionViolation
    {

        /** Default constructor. */
        public AccountNotUniqueException(){}

        /**
         * Constructs a new <code>AccountNotUniqueException</code> exception with the specified detail message.
         *
         * @param message the detail message.
         */
        public AccountNotUniqueException(String message)
        {
            super(message);
        }

        /**
         * Constructs a new <code>AccountNotUniqueException</code> exception with the specified detail message
         * and cause.
         *
         * @param message the detail message.
         * @param cause the cause.
         */
        public AccountNotUniqueException(String message, Throwable cause)
        {
            super(message, cause);
        }

        /**
         * Constructs a new <code>AccountNotUniqueException</code> exception with the specified cause.
         *
         * @param cause the cause.
         */
        public AccountNotUniqueException(Throwable cause)
        {
            super(cause);
        }

    }


    class UnsupportedSearchCriteriaException extends PreconditionViolation
    {

        /** Default constructor. */
        public UnsupportedSearchCriteriaException(){}

        /**
         * Constructs a new <code>UnsupportedSearchCriteriaException</code> exception with the specified detail message.
         *
         * @param message the detail message.
         */
        public UnsupportedSearchCriteriaException(String message)
        {
            super(message);
        }

        /**
         * Constructs a new <code>UnsupportedSearchCriteriaException</code> exception with the specified detail message
         * and cause.
         *
         * @param message the detail message.
         * @param cause the cause.
         */
        public UnsupportedSearchCriteriaException(String message, Throwable cause)
        {
            super(message, cause);
        }

        /**
         * Constructs a new <code>UnsupportedSearchCriteriaException</code> exception with the specified cause.
         *
         * @param cause the cause.
         */
        public UnsupportedSearchCriteriaException(Throwable cause)
        {
            super(cause);
        }

    }
}
