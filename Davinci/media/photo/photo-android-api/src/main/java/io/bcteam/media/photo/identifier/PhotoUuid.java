package io.bcteam.media.photo.identifier;

public class PhotoUuid extends PhotoIdentifier
{
    private String uuid;

    public String getUuid()
    {
        return uuid;
    }

    public PhotoUuid setUuid(String uuid)
    {
        this.uuid = uuid;
        return this;
    }
}
