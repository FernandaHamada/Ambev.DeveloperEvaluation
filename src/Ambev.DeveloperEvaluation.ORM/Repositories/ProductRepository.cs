using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DefaultContext _context;

    public ProductRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default)
    {
        await _context.Products.AddAsync(product, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return product;
    }

    public async Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _context.Products.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public async Task<Product?> GetByTitleAsync(string title, CancellationToken cancellationToken = default)
    {
        return await _context.Products
            .FirstOrDefaultAsync(p => p.Title == title, cancellationToken);
    }

    public async Task<IQueryable<Product>> GetByCategoryAsync(string category, CancellationToken cancellationToken = default)
    {
        return _context.Products
            .Where(p => p.Category == category)
            .AsNoTracking();
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var product = await GetByIdAsync(id, cancellationToken);
        if (product == null)
            return false;

        _context.Products.Remove(product);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default)
    {
        var exists = await _context.Products
            .AsNoTracking().AnyAsync(u => u.Id == product.Id, cancellationToken);

        if (!exists)
            return null;

        _context.Products.Update(product);
        await _context.SaveChangesAsync(cancellationToken);
        return product;
    }

    public async Task<IQueryable<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return _context.Products.AsNoTracking();
    }

    public async Task<IEnumerable<string>> ListCategoriesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Products.Select(p => p.Category).Distinct().ToListAsync();
    }
}
