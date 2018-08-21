package io.bcteam.media.photo.search.criteria;

import io.bcteam.media.photo.identifier.PhotoIdentifier;
import io.bcteam.search.criteria.SearchCriteria;

public class PhotoIdentifierSearch extends SearchCriteria
{
    private PhotoIdentifier photoIdentifier;

    public PhotoIdentifier getPhotoIdentifier()
    {
        return photoIdentifier;
    }

    public PhotoIdentifierSearch setPhotoIdentifier(PhotoIdentifier photoIdentifier)
    {
        this.photoIdentifier = photoIdentifier;
        return this;
    }
}
