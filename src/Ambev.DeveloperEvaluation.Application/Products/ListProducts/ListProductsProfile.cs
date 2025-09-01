using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

public class ListUsersProfile : Profile
{
    public ListUsersProfile()
    {
        CreateMap<ProductRating, RatingResult>();
        CreateMap<Product, ProductResult>()
            .ForMember(dest => dest.Image,
                opt => opt.MapFrom(src => src.Image != null ? Convert.ToBase64String(src.Image) : null));
    }
}
