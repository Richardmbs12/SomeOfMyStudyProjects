package io.bcteam.media.photo.identifier;

public class PhotoTag extends PhotoIdentifier
{
    private String tagName;
    private String tagValue;

    public String getTagName()
    {
        return tagName;
    }

    public PhotoTag setTagName(String tagName)
    {
        this.tagName = tagName;
        return this;
    }

    public String getTagValue()
    {
        return tagValue;
    }

    public PhotoTag setTagValue(String tagValue)
    {
        this.tagValue = tagValue;
        return this;

    }
}
