using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;
using System.Globalization;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class CartValidator : AbstractValidator<Cart>
{
    public CartValidator()
    {
        RuleFor(cart => cart.UserId)
            .NotEmpty()
            .WithMessage("User Id is required.");

        RuleFor(cart => cart.Date)
            .NotEmpty()
            .WithMessage("Date cannot be empty.")
            .Must(BeAValidDate)
            .WithMessage("Cart date must be in the yyyy-MM-dd format.");

        RuleFor(c => c.CartProducts)
            .NotEmpty()
            .WithMessage("Cart must contain at least one product.");

        RuleForEach(c => c.CartProducts).SetValidator(new CartProductsValidator());

    }

    private bool BeAValidDate(string date)
    {
        return DateTime.TryParseExact(
            date,
            "yyyy-MM-dd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out _
        );
    }
}

public class CartProductsValidator : AbstractValidator<CartProducts>
{
    public CartProductsValidator()
    {
        RuleFor(cp => cp.ProductId)
            .GreaterThan(0)
            .WithMessage("ProductId is required.");

        RuleFor(cp => cp.Quantity)
            .GreaterThan(0)
            .WithMessage("Quantity must be greater than zero.");
    }
}
