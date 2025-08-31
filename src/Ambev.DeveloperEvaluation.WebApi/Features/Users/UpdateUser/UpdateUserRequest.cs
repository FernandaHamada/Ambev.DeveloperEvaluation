using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser;

public class UpdateUserRequest
{
    public string Username { get; set; } = string.Empty;
    public UpdateNameRequest Name { get; set; }
    public UpdateAddressRequest Address { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserStatus Status { get; set; }
    public UserRole Role { get; set; }
}

public class UpdateNameRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class UpdateAddressRequest
{
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public int Number { get; set; }
    public string ZipCode { get; set; } = string.Empty;
    public UpdateGeolocationRequest Geolocation { get; set; }
}

public class UpdateGeolocationRequest
{
    public string Lat { get; set; } = string.Empty;
    public string Long { get; set; } = string.Empty;
}