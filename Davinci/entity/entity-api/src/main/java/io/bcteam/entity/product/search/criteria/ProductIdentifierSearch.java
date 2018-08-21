package io.bcteam.entity.product.search.criteria;

import io.bcteam.entity.product.identifier.ProductIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

public class ProductIdentifierSearch extends SearchCriteria {
    private ProductIdentifier personIdentifier;

    public ProductIdentifier getProductIdentifier()
    {
        return personIdentifier;
    }

    public ProductIdentifierSearch setProductIdentifier(ProductIdentifier personIdentifier)
    {
        this.personIdentifier = personIdentifier;
        return this;
    }
}
