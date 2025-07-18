﻿using App.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace App.Datasources.Commands.CreateDatasource;

public class CreateDatasourceCommandValidator : AbstractValidator<CreateDatasourceCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateDatasourceCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Name)
            .NotEmpty()
            .MaximumLength(200)
            .MustAsync(BeUniqueName)
                .WithMessage("'{PropertyName}' must be unique.")
                .WithErrorCode("Unique");
    }

    public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
    {
        return await _context.Datasources
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}
