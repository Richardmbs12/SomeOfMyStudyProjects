package io.bcteam.logistical.order.search.criteria;

import io.bcteam.logistical.order.identifier.OrderIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

public class OrderIdentifierSearch extends SearchCriteria {
    private OrderIdentifier orderIdentifier;

    public OrderIdentifier getOrderIdentifier()
    {
        return orderIdentifier;
    }

    public OrderIdentifierSearch setNaturalPaymentIdentifier(OrderIdentifier orderIdentifier)
    {
        this.orderIdentifier = orderIdentifier;
        return this;
    }
}
