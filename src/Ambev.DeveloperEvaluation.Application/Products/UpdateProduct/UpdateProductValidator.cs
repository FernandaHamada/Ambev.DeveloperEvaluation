using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.Title)
            .NotEmpty()
            .WithMessage("Product title cannot be empty.")
            .MinimumLength(3)
            .WithMessage("Product title must be at least 3 characters long.")
            .MaximumLength(100)
            .WithMessage("Product title cannot be longer than 100 characters.");

        RuleFor(product => product.Price)
            .GreaterThan(0)
            .WithMessage("Product price must be greater than zero.");

        RuleFor(product => product.Description)
            .NotEmpty()
            .WithMessage("Product description cannot be empty.")
            .MinimumLength(10)
            .WithMessage("Product description must be at least 10 characters long.")
            .MaximumLength(1000)
            .WithMessage("Product description cannot be longer than 1000 characters.");

        RuleFor(product => product.Category)
            .NotEmpty()
            .WithMessage("Product category cannot be empty.")
            .MinimumLength(2)
            .WithMessage("Product category must be at least 2 characters long.")
            .MaximumLength(50)
            .WithMessage("Product category cannot be longer than 50 characters.");

        RuleFor(product => product.Image)
            .NotEmpty()
            .WithMessage("Product image cannot be empty.");

        RuleFor(product => product.Rating.Rate)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(5)
            .WithMessage("Product rating rate must be between 0 and 5.");

        RuleFor(product => product.Rating.Count)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Product rating count must be greater than or equal to 0.");
    }
}
