package io.bcteam.security.account.identifier;

public class AccountEmail extends AccountIdentifier{
    private String email;

    public String getEmail()
    {
        return email;
    }

    public AccountEmail setEmail(String email)
    {
        this.email = email;
        return this;
    }
}
