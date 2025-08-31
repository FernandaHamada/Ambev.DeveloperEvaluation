using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;


public interface IProductRepository
{
    Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);
    Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Product?> GetByTitleAsync(string title, CancellationToken cancellationToken = default);
    Task<IQueryable<Product>> GetByCategoryAsync(string category, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default);
    Task<IQueryable<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<string>> ListCategoriesAsync(CancellationToken cancellationToken = default);
}
