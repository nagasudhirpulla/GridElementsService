﻿using App.Common.Behaviours;
using App.Common.Interfaces;
using Ardalis.GuardClauses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace App.Buses.Commands.DeleteBus;

[Transactional(IsolationLevel = System.Data.IsolationLevel.Serializable)]
public record DeleteBusCommand(int Id) : IRequest;

public class DeleteBusCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteBusCommand>
{
    public async Task Handle(DeleteBusCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Buses
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Buses.Remove(entity);

        await context.SaveChangesAsync(cancellationToken);
    }
}