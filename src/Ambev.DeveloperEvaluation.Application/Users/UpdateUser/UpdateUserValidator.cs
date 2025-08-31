using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(user => user.Id).NotEmpty();
        RuleFor(user => user.Email).SetValidator(new EmailValidator());
        RuleFor(user => user.Username).NotEmpty().Length(3, 50);
        RuleFor(user => user.Name.FirstName).NotEmpty().Length(3, 50);
        RuleFor(user => user.Name.LastName).NotEmpty().Length(3, 100);
        RuleFor(user => user.Address.City).NotEmpty().Length(3, 100);
        RuleFor(user => user.Address.Street).NotEmpty();
        RuleFor(user => user.Address.ZipCode).NotEmpty();
        RuleFor(user => user.Address.Geolocation.Lat).NotEmpty();
        RuleFor(user => user.Address.Geolocation.Long).NotEmpty();
        RuleFor(user => user.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        RuleFor(user => user.Status).NotEqual(UserStatus.Unknown);
        RuleFor(user => user.Role).NotEqual(UserRole.None);
    }
}
