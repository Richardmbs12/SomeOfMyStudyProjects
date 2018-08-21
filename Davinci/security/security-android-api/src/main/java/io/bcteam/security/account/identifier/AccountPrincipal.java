package io.bcteam.security.account.identifier;

public class AccountPrincipal extends AccountIdentifier
{
    private String userName;

    public String getUserName()
    {
        return userName;
    }

    public AccountPrincipal setUserNameString(String userName)
    {
        this.userName = userName;
        return this;
    }
}
