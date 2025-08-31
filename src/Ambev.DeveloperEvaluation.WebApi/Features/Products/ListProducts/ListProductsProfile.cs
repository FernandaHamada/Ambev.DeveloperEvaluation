
using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.Response;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

public class ListProductsProfile : Profile
{
    public ListProductsProfile()
    {
        CreateMap<RatingResult, RatingResponse>();
        CreateMap<ProductResult, ProductResponse>();
        CreateMap<ListProductsRequest, ListProductsCommand>();
        CreateMap<PaginatedList<ProductResult>, PaginatedResponse<ProductResponse>>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.CurrentPage, opt => opt.MapFrom(src => src.CurrentPage))
            .ForMember(dest => dest.TotalPages, opt => opt.MapFrom(src => src.TotalPages))
            .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.TotalCount));
    }
}