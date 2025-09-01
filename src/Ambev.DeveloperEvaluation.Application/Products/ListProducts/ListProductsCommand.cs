using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.WebApi.Common;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

public class ListProductsCommand : IRequest<PaginatedList<ProductResult>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string Order { get; set; } = string.Empty;
}