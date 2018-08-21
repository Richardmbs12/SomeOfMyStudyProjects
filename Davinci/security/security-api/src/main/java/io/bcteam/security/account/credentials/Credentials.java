package io.bcteam.security.account.credentials;

import java.io.Serializable;

/**
 * Introduces the abstract context of credentials.
 *
 * Credentials may take of form of a username and password or a electronic representation of a biometric characteristic such as a scan of
 * a fingerprint.
 */

public abstract class Credentials implements Serializable {}