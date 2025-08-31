using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Users.Result;

namespace Ambev.DeveloperEvaluation.Application.Users.CreateUser;

/// <summary>
/// Profile for mapping between User entity and CreateUserResponse
/// </summary>
public class CreateUserProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateUser operation
    /// </summary>
    public CreateUserProfile()
    {
        CreateMap<NameCommand, Name>();
        CreateMap<AddressCommand, Address>();
        CreateMap<GeolocationCommand, Geolocation>();
        CreateMap<CreateUserCommand, User>();
        CreateMap<User, UserResult>();
        CreateMap<Name, NameResult>();
        CreateMap<Address, AddressResult>();
        CreateMap<Geolocation, GeolocationResult>();
    }
}
