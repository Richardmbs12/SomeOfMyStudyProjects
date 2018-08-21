package io.bcteam.logistical.order.identifier;

import io.bcteam.security.account.identifier.AccountIdentifier;

public class OrderByAccountIdentifier extends OrderIdentifier{
    private AccountIdentifier account;

    public AccountIdentifier getAccount() {
        return account;
    }

    public OrderByAccountIdentifier setAccount(AccountIdentifier account) {
        this.account = account;
        return this;
    }
}
