using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Application.Users.UpdateUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductProfile : Profile
{
    public UpdateProductProfile()
    {
        CreateMap<UpdateProductCommand, Product>().ForMember(dest => dest.Image,
                opt => opt.MapFrom(src =>
                    !string.IsNullOrEmpty(src.Image)
                        ? Convert.FromBase64String(src.Image)
                        : null)); ;
        CreateMap<UpdateRatingCommand, ProductRating>();
        CreateMap<Product, ProductResult>();
    }
}
