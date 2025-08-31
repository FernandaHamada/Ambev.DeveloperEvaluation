
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

public class ListUsersCommandValidator : AbstractValidator<ListUserCommand>
{
    public ListUsersCommandValidator()
    {
        RuleFor(x => x.PageNumber)
            .GreaterThan(0);

        RuleFor(x => x.PageSize)
            .GreaterThan(0);

        RuleFor(x => x.Order)
            .Must(BeValidOrder)
            .When(x => !string.IsNullOrEmpty(x.Order));
    }

    private bool BeValidOrder(string order)
    {
        if (string.IsNullOrEmpty(order)) return true;

        var validOrders = new[] { "username desc", "email desc", "username asc", "email asc" };
        return validOrders.Contains(order.ToLower());
    }
}
