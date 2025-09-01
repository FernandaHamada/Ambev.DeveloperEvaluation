using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

public class DeleteProductProfile : Profile
{
    public DeleteProductProfile()
    {
        CreateMap<int, Application.Products.DeleteProduct.DeleteProductCommand>()
            .ConstructUsing(id => new Application.Products.DeleteProduct.DeleteProductCommand(id));
    }
}
