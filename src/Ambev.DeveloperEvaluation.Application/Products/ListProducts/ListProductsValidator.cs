using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

public class ListProductsCommandValidator : AbstractValidator<ListProductsCommand>
{
    public ListProductsCommandValidator()
    {
        RuleFor(x => x.PageNumber)
            .GreaterThan(0);

        RuleFor(x => x.PageSize)
            .GreaterThan(0);

        RuleFor(x => x.Order)
            .Must(BeValidOrder)
            .When(x => !string.IsNullOrEmpty(x.Order));
    }

    private bool BeValidOrder(string order)
    {
        if (string.IsNullOrEmpty(order)) return true;

        var validOrders = new[] { "title desc", "price desc", "title asc", "price asc" };
        return validOrders.Contains(order.ToLower());
    }
}