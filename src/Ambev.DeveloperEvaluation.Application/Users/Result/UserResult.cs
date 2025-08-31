using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Users.Result;

public class UserResult
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The user's username
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// The user's full name
    /// </summary>
    public NameResult Name { get; set; }

    /// <summary>
    /// The user's full name
    /// </summary>
    public AddressResult Address { get; set; }

    /// <summary>
    /// The user's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// The user's role in the system
    /// </summary>
    public UserRole Role { get; set; }

    /// <summary>
    /// The current status of the user
    /// </summary>
    public UserStatus Status { get; set; }
}

public class NameResult
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class AddressResult
{
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public int Number { get; set; }
    public string ZipCode { get; set; } = string.Empty;
    public GeolocationResult Geolocation { get; set; }

}

public class GeolocationResult
{
    public string Lat { get; set; } = string.Empty;
    public string Long { get; set; } = string.Empty;
}
