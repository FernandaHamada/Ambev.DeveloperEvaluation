using Ambev.DeveloperEvaluation.Application.Users.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers
{
    public class ListUsersProfile : Profile
    {
        public ListUsersProfile()
        {
            CreateMap<Name, NameResult>();
            CreateMap<Address, AddressResult>();
            CreateMap<Geolocation, GeolocationResult>();
            CreateMap<User, UserResult>();
        }
    }
}
