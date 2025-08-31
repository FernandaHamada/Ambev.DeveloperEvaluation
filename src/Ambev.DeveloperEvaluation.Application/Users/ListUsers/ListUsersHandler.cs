using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.WebApi.Common;
using AutoMapper;
using FluentValidation;
using AutoMapper.QueryableExtensions;
using MediatR;
using Ambev.DeveloperEvaluation.Application.Users.Result;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

public class ListUsersHandler : IRequestHandler<ListUserCommand, PaginatedList<UserResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public ListUsersHandler(
        IUserRepository userRepository,
        IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<PaginatedList<UserResult>> Handle(ListUserCommand command, CancellationToken cancellationToken)
    {
        var validator = new ListUsersCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var query = await _userRepository.GetAllAsync(cancellationToken);
        query = ApplyOrdering(query, command.Order);

        return await PaginatedList<UserResult>.CreateAsync(query.ProjectTo<UserResult>(_mapper.ConfigurationProvider), command.PageNumber, command.PageSize);
    }

    private IQueryable<User> ApplyOrdering(IQueryable<User> query, string order)
    {
        return order?.ToLower() switch
        {
            "username desc" => query.OrderByDescending(u => u.Username),
            "email desc" => query.OrderByDescending(u => u.Email),
            "username asc" => query.OrderBy(u => u.Username),
            "email asc" => query.OrderBy(u => u.Email),
            _ => query.OrderBy(u => u.Id)
        };
    }
}
