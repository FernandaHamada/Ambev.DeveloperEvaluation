namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.Response;

public class ProductResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public RatingResponse Rating { get; set; }
}

public class RatingResponse
{
    public decimal Rate { get; set; }
    public int Count { get; set; }
}
