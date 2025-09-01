using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllCategories;

public class GetAllCategoriesCommand : IRequest<IEnumerable<GetAllCategoriesResult>>
{
}
