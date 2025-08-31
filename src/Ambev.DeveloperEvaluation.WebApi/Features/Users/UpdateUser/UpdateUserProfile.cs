using Ambev.DeveloperEvaluation.Application.Users.UpdateUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.Response;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser;

public class UpdateUserProfile : Profile
{
    public UpdateUserProfile()
    {
        CreateMap<UpdateNameRequest, NameCommand>();
        CreateMap<UpdateAddressRequest, AddressCommand>();
        CreateMap<UpdateGeolocationRequest, GeolocationCommand>();
        CreateMap<UpdateUserRequest, UpdateUserCommand>();
        CreateMap<UpdateUserRequest, UserResponse>();
    }
}
