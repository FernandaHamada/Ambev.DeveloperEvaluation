using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

internal class GetProductProfile : Profile
{
    public GetProductProfile()
    {
        CreateMap<ProductRating, RatingResult>();
        CreateMap<Product, ProductResult>()
            .ForMember(dest => dest.Image,
            opt => opt.MapFrom(src => src.Image != null ? Convert.ToBase64String(src.Image) : null));
    }
}
