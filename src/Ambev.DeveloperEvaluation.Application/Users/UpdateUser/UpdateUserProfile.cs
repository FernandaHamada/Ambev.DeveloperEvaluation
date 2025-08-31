using Ambev.DeveloperEvaluation.Application.Users.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser;

public class UpdateUserProfile : Profile
{
    public UpdateUserProfile()
    {
        CreateMap<NameCommand, Name>();
        CreateMap<AddressCommand, Address>();
        CreateMap<GeolocationCommand, Geolocation>();
        CreateMap<UpdateUserCommand, User>();
        CreateMap<User, UserResult>();
    }
}

