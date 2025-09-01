using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.WebApi.Common;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProductsByCategory;

public class ListProductsByCategoryCommand : IRequest<PaginatedList<ProductResult>>
{
    public string CategoryName { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string Order { get; set; } = string.Empty;
}
