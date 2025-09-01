using Ambev.DeveloperEvaluation.Application.Products.GetAllCategories;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetCategories;

public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesCommand, IEnumerable<GetAllCategoriesResult>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetAllCategoriesHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllCategoriesResult>> Handle(GetAllCategoriesCommand request, CancellationToken cancellationToken)
    {

        var categories = await _productRepository.ListCategoriesAsync(cancellationToken);
        if (categories.Count() == 0 )
            throw new KeyNotFoundException($"Categories not found");

        return _mapper.Map<IEnumerable<GetAllCategoriesResult>>(categories);
    }
}
