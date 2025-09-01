namespace Ambev.DeveloperEvaluation.Common.Security;

public interface IProduct
{
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public byte[]? Image { get; set; }
    public IProductRating Rating { get; set; }
}

public interface IProductRating
{
    public decimal Rate { get; }
    public int Count { get; }
}
