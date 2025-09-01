
using Ambev.DeveloperEvaluation.Application.Products.Result;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

public class GetProductCommand : IRequest<ProductResult>
{
    public int Id { get; }
    public GetProductCommand(int id)
    {
        Id = id;
    }
}
