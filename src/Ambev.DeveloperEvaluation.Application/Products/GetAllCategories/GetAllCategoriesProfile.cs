using Ambev.DeveloperEvaluation.Application.Products.GetAllCategories;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.GetCategories;

public class GetAllCategoriesProfile : Profile
{
    public GetAllCategoriesProfile()
    {
        CreateMap<string, GetAllCategoriesResult>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src)); ;
    }
}
