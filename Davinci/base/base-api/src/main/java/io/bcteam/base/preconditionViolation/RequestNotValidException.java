package io.bcteam.base.preconditionViolation;

public class RequestNotValidException extends PreconditionViolation
{

    /** Default constructor. */
    public RequestNotValidException(){}

    /**
     * Constructs a new <code>UnsupportedNaturalPersonIdentifierException</code> exception with the specified detail message.
     *
     * @param message the detail message.
     */
    public RequestNotValidException(String message)
    {
        super(message);
    }

    /**
     * Constructs a new <code>UnsupportedNaturalPersonIdentifierException</code> exception with the specified detail message
     * and cause.
     *
     * @param message the detail message.
     * @param cause the cause.
     */
    public RequestNotValidException(String message, Throwable cause)
    {
        super(message, cause);
    }

    /**
     * Constructs a new <code>UnsupportedSearchCriteriaException</code> exception with the specified cause.
     *
     * @param cause the cause.
     */
    public RequestNotValidException(Throwable cause)
    {
        super(cause);
    }

}
