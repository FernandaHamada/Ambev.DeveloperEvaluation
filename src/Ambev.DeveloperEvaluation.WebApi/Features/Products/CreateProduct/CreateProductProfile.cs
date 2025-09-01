using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.Response;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

public class CreateProductProfile : Profile
{
    public CreateProductProfile()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>();
        CreateMap<ProductRatingRequest, ProductRatingCommand>();
        CreateMap<ProductResult, ProductResponse>();
        CreateMap<RatingResult, RatingResponse>();
    }
}