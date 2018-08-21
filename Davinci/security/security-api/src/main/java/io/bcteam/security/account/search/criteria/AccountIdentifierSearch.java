package io.bcteam.security.account.search.criteria;


import io.bcteam.search.criteria.SearchCriteria;
import io.bcteam.security.account.identifier.AccountIdentifier;

public class AccountIdentifierSearch extends SearchCriteria
{
    private AccountIdentifier accountIdentifier;

    public AccountIdentifier getAccountIdentifier()
    {
        return accountIdentifier;
    }

    public AccountIdentifierSearch setAccountIdentifier(AccountIdentifier accountIdentifier)
    {
        this.accountIdentifier = accountIdentifier;
        return this;
    }
}
