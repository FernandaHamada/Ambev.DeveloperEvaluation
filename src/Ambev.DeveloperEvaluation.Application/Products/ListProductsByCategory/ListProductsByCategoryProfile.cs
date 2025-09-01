using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProductsByCategory;

public class ListProductsByCategoryProfile : Profile
{
    public ListProductsByCategoryProfile()
    {
        CreateMap<Product, ProductResult>()
            .ForMember(dest => dest.Image,
                opt => opt.MapFrom(src => src.Image != null ? Convert.ToBase64String(src.Image) : null)); ;
        CreateMap<ProductRating, RatingResult>();
    }
}
