using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

public class CreateProductProfile : Profile
{
    public CreateProductProfile()
    {
        CreateMap<ProductRatingCommand, ProductRating>();
        CreateMap<CreateProductCommand, Product>().ForMember(dest => dest.Image,
                opt => opt.MapFrom(src =>
                    !string.IsNullOrEmpty(src.Image)
                        ? Convert.FromBase64String(src.Image)
                        : null));
        CreateMap<ProductRating, RatingResult>();
        CreateMap<Product, ProductResult>().ForMember(dest => dest.Image,
        opt => opt.MapFrom(src => src.Image != null ? Convert.ToBase64String(src.Image) : null));
    }
}
