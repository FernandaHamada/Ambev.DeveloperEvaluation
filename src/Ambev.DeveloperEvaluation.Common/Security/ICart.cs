namespace Ambev.DeveloperEvaluation.Common.Security;

public interface ICart
{
    public int Id { get; }
    public string UserId { get; }
    public string Date { get; }
    public IEnumerable<ICartProducts> CartProducts { get; }
}

public interface ICartProducts
{
    public int CartId { get; }
    public int ProductId { get; }
    public int Quantity { get; }
}

