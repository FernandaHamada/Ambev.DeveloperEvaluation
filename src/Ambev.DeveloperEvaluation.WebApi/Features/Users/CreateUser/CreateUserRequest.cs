using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;

/// <summary>
/// Represents a request to create a new user in the system.
/// </summary>
public class CreateUserRequest
{
    /// <summary>
    /// Gets or sets the username. Must be unique and contain only valid characters.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password. Must meet security requirements.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name. Must meet security requirements.
    /// </summary>
    public NameRequest Name { get; set; }

    /// <summary>
    /// Gets or sets the address. Must meet security requirements
    /// </summary>
    public AddressRequest Address { get; set; }

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

public class NameRequest
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

public class AddressRequest
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
    public GeolocationRequest Geolocation { get; set; }
}

public class GeolocationRequest
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