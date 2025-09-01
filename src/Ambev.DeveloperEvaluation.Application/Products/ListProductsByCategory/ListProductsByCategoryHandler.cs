using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using Ambev.DeveloperEvaluation.Application.Products.Result;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.WebApi.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProductsByCategory;

internal class ListProductsByCategoryHandler : IRequestHandler<ListProductsByCategoryCommand, PaginatedList<ProductResult>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ListProductsByCategoryHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<ProductResult>> Handle(ListProductsByCategoryCommand command, CancellationToken cancellationToken)
    {
        var validator = new ListProductsByCategoryValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var query = await _productRepository.GetAllByCategoryAsync(command.CategoryName, cancellationToken);

        if (!query.Any())
            throw new KeyNotFoundException("No products found.");

        query = ApplyOrdering(query, command.Order);

        var productResults = _mapper.Map<List<ProductResult>>(query.ToList());

        return await PaginatedList<ProductResult>.CreateAsync(
            query.ProjectTo<ProductResult>(_mapper.ConfigurationProvider),
            command.PageNumber,
            command.PageSize
        );
    }

    private IQueryable<Product> ApplyOrdering(IQueryable<Product> query, string order)
    {
        return order?.ToLower() switch
        {
            "title desc" => query.OrderByDescending(p => p.Title),
            "price desc" => query.OrderByDescending(p => p.Price),
            "title asc" => query.OrderBy(p => p.Title),
            "price asc" => query.OrderBy(p => p.Price),
            _ => query.OrderBy(p => p.Id)
        };
    }
}
