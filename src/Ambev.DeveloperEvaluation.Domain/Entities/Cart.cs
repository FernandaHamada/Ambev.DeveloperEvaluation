using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Cart : BaseEntity, ICart
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Date { get; set; } = string.Empty;
    int ICart.Id => Id;
    public ICollection<CartProducts> CartProducts { get; set; } = new List<CartProducts>();
    string ICart.UserId => UserId.ToString();
    string ICart.Date => Date.ToString();
    IEnumerable<ICartProducts> ICart.CartProducts => CartProducts;

    public ValidationResultDetail Validate()
    {
        var validator = new CartValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}

public class CartProducts : BaseEntity, ICartProducts
{
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    int ICartProducts.CartId => CartId;
    int ICartProducts.ProductId => ProductId;

    public Cart Cart { get; set; }
    public Product Product { get; set; }

    public ValidationResultDetail Validate()
    {
        var validator = new CartProductsValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}
