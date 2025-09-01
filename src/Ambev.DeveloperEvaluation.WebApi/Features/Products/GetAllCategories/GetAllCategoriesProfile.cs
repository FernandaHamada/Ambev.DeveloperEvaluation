using Ambev.DeveloperEvaluation.Application.Products.GetAllCategories;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetAllCategories;

public class GetAllCategoriesProfile : Profile
{
    public GetAllCategoriesProfile() 
    {
        CreateMap<GetAllCategoriesResult, GetAllCategoriesResponse>();
    }
}
