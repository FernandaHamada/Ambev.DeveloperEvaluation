using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
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
            .NotEmpty();

        RuleFor(product => product.Rating.Count)
           .NotEmpty();

        RuleFor(product => product.Status)
            .IsInEnum()
            .WithMessage("Product status must be a valid ProductStatus value.");

        RuleFor(product => product.CreatedAt)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("Product creation date cannot be in the future.");

        When(product => product.UpdatedAt.HasValue, () =>
        {
            RuleFor(product => product.UpdatedAt)
                .GreaterThan(product => product.CreatedAt)
                .WithMessage("Product update date must be after creation date.");
        });
    }

    private bool BeValidImagePath(string imagePath)
    {
        if (string.IsNullOrWhiteSpace(imagePath))
            return false;

        if (Uri.TryCreate(imagePath, UriKind.Absolute, out var uri))
        {
            return uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps;
        }

        var validExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
        var extension = Path.GetExtension(imagePath).ToLowerInvariant();
        return validExtensions.Contains(extension);
    }
}
