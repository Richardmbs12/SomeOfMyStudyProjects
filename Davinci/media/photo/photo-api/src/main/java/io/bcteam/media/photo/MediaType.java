package io.bcteam.media.photo;

/**
 * Standard image formats
 */
public enum MediaType
{
    JPEG("image/jpeg"),
    PNG("image/png"),
    TIFF("image/tiff");

    private String template;

    MediaType(String template)
    {
        this.template = template;
    }

    public String getTemplate()
    {
        return template;
    }

    public MediaType setTemplate(String template)
    {
        this.template = template;
        return this;
    }
}
