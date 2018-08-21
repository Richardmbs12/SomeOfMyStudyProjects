package io.bcteam.base.preconditionViolation;

public class PreconditionViolation extends Exception {
    public PreconditionViolation() {
        super();
    }

    public PreconditionViolation(String message) {
        super(message);
    }

    public PreconditionViolation(String message, Throwable cause) {
        super(message, cause);
    }

    public PreconditionViolation(Throwable cause) {
        super(cause);
    }
}
