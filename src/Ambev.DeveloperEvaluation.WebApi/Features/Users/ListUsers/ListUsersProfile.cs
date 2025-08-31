using Ambev.DeveloperEvaluation.Application.Users.ListUsers;
using Ambev.DeveloperEvaluation.Application.Users.Result;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.Response;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersProfile : Profile
{
    public ListUsersProfile()
    {
        CreateMap<NameResult, NameResponse>();
        CreateMap<AddressResult, AddressResponse>();
        CreateMap<GeolocationResult, GeolocationResponse>();
        CreateMap<UserResult, UserResponse>();
        CreateMap<ListUsersRequest, ListUserCommand>();
        CreateMap<PaginatedList<UserResult>, PaginatedResponse<UserResponse>>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.CurrentPage, opt => opt.MapFrom(src => src.CurrentPage))
            .ForMember(dest => dest.TotalPages, opt => opt.MapFrom(src => src.TotalPages))
            .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.TotalCount));
    }
}

