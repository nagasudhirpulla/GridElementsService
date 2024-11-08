﻿using App.Common.Interfaces;
using App.Owners.Utils;
using Core.Entities.Elements;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace App.Lines.Commands.CreateLine;

public class CreateLineCommandValidator : AbstractValidator<CreateLineCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateLineCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.OwnerIds)
            .NotEmpty();

        RuleFor(v => v.Bus1Id)
            .NotEmpty();

        RuleFor(v => v.Bus1Id)
            .NotEqual(l => l.Bus2Id);

        RuleFor(v => v.Bus2Id)
            .NotEmpty();

        RuleFor(v => v.Length)
            .GreaterThan(0);

        RuleFor(v => v.ConductorType)
            .NotEmpty();

        RuleFor(v => v.Bus1Id)
            .MustAsync(BeAnAcBus)
                .WithMessage("Bus is not an AC Bus")
                .WithErrorCode("Invalid");

        RuleFor(v => v)
            .MustAsync(BeSameVoltageLevelBuses)
                .WithMessage("Voltage levels of both buses is not same")
                .WithErrorCode("Invalid");

        RuleFor(v => v.Bus1Id)
            .MustAsync(BeAnAcBus)
                .WithMessage("Bus is not an AC Bus")
                .WithErrorCode("Invalid");

        RuleFor(v => v.OwnerIds)
            .Must(OwnerUtils.BeValidOwnerIds)
                .WithMessage("invalid owner Ids provided")
                .WithErrorCode("Unique");

        RuleFor(v => v)
            .MustAsync(BeUniqueLinesBetweenSubstations)
                .WithMessage("The combination of From and To buses and line number should be unique")
                .WithErrorCode("Unique");

        RuleFor(v => v)
            .Must(cmd => !cmd.DeCommissioningDate.HasValue || (cmd.DeCommissioningDate > cmd.CommissioningDate))
                .WithMessage("Decommissioning date should be greater than Commissioning Date")
                .WithErrorCode("Invalid");

        RuleFor(v => v)
            .Must(cmd => cmd.CommercialOperationDate > cmd.CommissioningDate)
                .WithMessage("Commercial Operation Date date should be greater than Commissioning Date")
                .WithErrorCode("Invalid");
    }

    public async Task<bool> BeUniqueLinesBetweenSubstations(CreateLineCommand cmd, CancellationToken cancellationToken)
    {
        // combination of FromBus, ToBus and Element number is unique
        bool sameBusExists = await _context.Lines
            .AnyAsync(l => (l.Bus1Id == cmd.Bus1Id) && (l.Bus2Id == cmd.Bus2Id) && (l.ElementNumber == cmd.ElementNumber), cancellationToken);
        return !sameBusExists;
    }

    public async Task<bool> BeAnAcBus(int busId, CancellationToken cancellationToken)
    {
        return await Buses.Utils.IsAnAcBus.ExecuteAsync(busId, _context, cancellationToken);
    }

    public async Task<bool> BeSameVoltageLevelBuses(CreateLineCommand cmd, CancellationToken cancellationToken)
    {
        // bus1 and bus2 should have same voltage levels
        Bus bus1 = await _context.Buses.AsNoTracking()
                        .FirstOrDefaultAsync(s => s.Id == cmd.Bus1Id, cancellationToken: cancellationToken) ?? throw new KeyNotFoundException();
        Bus bus2 = await _context.Buses.AsNoTracking()
                        .FirstOrDefaultAsync(s => s.Id == cmd.Bus2Id, cancellationToken: cancellationToken) ?? throw new KeyNotFoundException();
        //bus1.VoltLevelCache
        bool isVoltLvlSame = bus1.VoltLevelCache == bus2.VoltLevelCache;
        return isVoltLvlSame;
    }
}