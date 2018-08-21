package io.bcteam.security.account.credentials;

/** A set of username and password credentials. */

public class PlainTextUsernameAndPassword extends Credentials
{
    private String password;

    private String username;

    /** Default constructor. */
    public PlainTextUsernameAndPassword(){}

    /** The user's unique username. */
    public String getUsername()
    {
        return username;
    }

    public PlainTextUsernameAndPassword setUsername(String username)
    {
        this.username = username;
        return this;
    }

    /** The user's password. */
    public String getPassword()
    {
        return password;
    }

    public PlainTextUsernameAndPassword setPassword(String password)
    {
        this.password = password;
        return this;
    }

}