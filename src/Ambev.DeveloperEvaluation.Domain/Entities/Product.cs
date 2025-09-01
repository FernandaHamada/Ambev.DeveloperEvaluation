using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product : BaseEntity, IProduct
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public byte[]? Image { get; set; }
    public ProductRating Rating { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public ProductStatus Status { get; set; }
    int IProduct.Id => Id;
    string IProduct.Title { get; set; } = string.Empty;
    string IProduct.Description { get; set; } = string.Empty;
    string IProduct.Category { get; set; } = string.Empty;
    byte[] IProduct.Image { get; set; }
    IProductRating IProduct.Rating { get; set; }


    public Product()
    {
        CreatedAt = DateTime.UtcNow;
    }

    public void Activate()
    {
        Status = ProductStatus.Active;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        Status = ProductStatus.Inactive;
        UpdatedAt = DateTime.UtcNow;
    }

    public ValidationResultDetail Validate()
    {
        var validator = new ProductValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}

[Owned]
public class ProductRating
{
    public decimal Rate { get; set; }
    public int Count { get; set; }
}