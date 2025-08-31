using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;

/// <summary>
/// API response model for CreateUser operation
/// </summary>
public class CreateUserResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The user's full name
    /// </summary>
    public NameResponse Name { get; set; }

    public AddressResponse Address { get; set; }

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

public class NameResponse
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

public class AddressResponse
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
    public GeolocationResponse Geolocation { get; set; }
}

public class GeolocationResponse
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