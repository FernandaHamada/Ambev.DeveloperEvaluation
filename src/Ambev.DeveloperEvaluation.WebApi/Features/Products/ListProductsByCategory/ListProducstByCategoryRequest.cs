namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetCategory;

public class ListProductByCategoryRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string Order { get; set; } = string.Empty;
}
