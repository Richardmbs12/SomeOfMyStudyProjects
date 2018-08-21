package io.bcteam.media.photo;

import java.io.Serializable;
import java.util.Map;

public class Photo implements Serializable
{
    private String uuid;
    private String base64BinaryData;
    private MediaType mediaType;
    private String description;
    private Map<String, String> tags;

    public MediaType getMediaType()
    {
        return mediaType;
    }

    public Photo setMediaType(MediaType mediaType)
    {
        this.mediaType = mediaType;
        return this;
    }

    public String getBase64BinaryData()
    {
        return base64BinaryData;
    }

    public Photo setBase64BinaryData(String base64BinaryData)
    {
        this.base64BinaryData = base64BinaryData;
        return this;
    }

    public String getUuid()
    {
        return uuid;
    }

    public Photo setUuid(String uuid)
    {
        this.uuid = uuid;
        return this;
    }

    public String getDescription()
    {
        return description;
    }

    public Photo setDescription(String description)
    {
        this.description = description;
        return this;
    }

    public Map<String, String> getTags()
    {
        return tags;
    }

    public Photo setTags(Map<String, String> tags)
    {
        this.tags = tags;
        return this;
    }
}
