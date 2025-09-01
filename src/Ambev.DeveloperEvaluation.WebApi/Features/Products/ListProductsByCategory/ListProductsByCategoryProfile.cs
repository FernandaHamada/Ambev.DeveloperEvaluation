using Ambev.DeveloperEvaluation.Application.Products.ListProductsByCategory;
using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.Response;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProductsByCategory;

public class ListProductsByCategoryProfile : Profile
{
    public ListProductsByCategoryProfile()
    {
        CreateMap<ListProductsByCategoryRequest, ListProductsByCategoryCommand>();
        CreateMap<ProductResult, ProductResponse>();
        CreateMap<PaginatedList<ProductResult>, PaginatedResponse<ProductResponse>>()
       .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src))
       .ForMember(dest => dest.CurrentPage, opt => opt.MapFrom(src => src.CurrentPage))
       .ForMember(dest => dest.TotalPages, opt => opt.MapFrom(src => src.TotalPages))
       .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.TotalCount));
    }
}