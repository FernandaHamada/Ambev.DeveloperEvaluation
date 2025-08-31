using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Users.CreateUser;

/// <summary>
/// Represents the response returned after successfully creating a new user.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created user,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateUserResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created user.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created user in the system.</value>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's full name
    /// </summary>
    public NameResult Name { get; set; }

    public AddressResult Address { get; set; }

    /// <summary>
    /// Gets or sets the phone number in format (XX) XXXXX-XXXX.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address. Must be a valid email format.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the initial status of the user account.
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the role assigned to the user.
    /// </summary>
    public UserRole Role { get; set; }
}

public class NameResult
{
    /// <summary>
    /// Gets or sets the first name. Must meet security requirements.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last name. Must meet security requirements.
    /// </summary>
    public string LastName { get; set; } = string.Empty;
}

public class AddressResult
{
    /// <summary>
    /// Gets or sets the city. Must meet security requirements
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the street. Must meet security requirements
    /// </summary>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the number. Must meet security requirements
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the zip code. Must meet security requirements
    /// </summary>
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the geolocation. Must meet security requirements
    /// </summary>
    public GeolocationResult Geolocation { get; set; }
}

public class GeolocationResult
{
    /// <summary>
    /// Gets or sets the latitude. Must meet security requirements
    /// </summary>
    public string Lat { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the longitude. Must meet security requirements
    /// </summary>
    public string Long { get; set; } = string.Empty;
}