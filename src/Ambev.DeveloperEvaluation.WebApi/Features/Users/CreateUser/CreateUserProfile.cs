using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.Response;
using Ambev.DeveloperEvaluation.Application.Users.Result;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;

/// <summary>
/// Profile for mapping between Application and API CreateUser responses
/// </summary>
public class CreateUserProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateUser feature
    /// </summary>
    public CreateUserProfile()
    {
        CreateMap<NameRequest, NameCommand>();
        CreateMap<AddressRequest, AddressCommand>();
        CreateMap<GeolocationRequest, GeolocationCommand>();
        CreateMap<CreateUserRequest, CreateUserCommand>();
        CreateMap<UserResult, UserResponse>();
        CreateMap<NameResult, NameResponse>();
        CreateMap<AddressResult, AddressResponse>();
        CreateMap<GeolocationResult, GeolocationResponse>();
    }
}
