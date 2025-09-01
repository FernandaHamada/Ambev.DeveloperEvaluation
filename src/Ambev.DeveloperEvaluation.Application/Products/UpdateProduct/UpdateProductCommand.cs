using Ambev.DeveloperEvaluation.Application.Products.Result;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ProductResult>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public UpdateRatingCommand Rating { get; set; }
    }

    public class UpdateRatingCommand
    {
        public decimal Rate { get; set; }
        public int Count { get; set; }
    }
}
