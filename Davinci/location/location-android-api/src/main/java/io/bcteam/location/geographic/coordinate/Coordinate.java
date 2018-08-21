package io.bcteam.location.geographic.coordinate;

import java.io.Serializable;

/**
 * Object representation of a GPS coordinate
 */
public class Coordinate implements Serializable
{
    private Double latitude;
    private Double longitude;

    public Double getLatitude()
    {
        return latitude;
    }

    public Coordinate setLatitude(Double latitude)
    {
        this.latitude = latitude;
        return this;
    }

    public Double getLongitude()
    {
        return longitude;
    }

    public Coordinate setLongitude(Double longitude)
    {
        this.longitude = longitude;
        return this;
    }
}
