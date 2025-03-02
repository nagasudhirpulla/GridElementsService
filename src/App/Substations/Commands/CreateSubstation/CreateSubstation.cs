﻿using App.Common.Behaviours;
using App.Common.Interfaces;
using App.Owners.Utils;
using App.Substations.Utils;
using Core.Entities;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace App.Substations.Commands.CreateSubstation;

[Transactional(IsolationLevel = System.Data.IsolationLevel.Serializable)]
public record CreateSubstationCommand : IRequest<int>
{
    public required string OwnerIds { get; init; }
    public int VoltageLevelId { get; set; }
    public int LocationId { get; set; }
    public bool IsAc { get; set; } = true;
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}

public class CreateSubstationCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateSubstationCommand, int>
{
    public async Task<int> Handle(CreateSubstationCommand request, CancellationToken cancellationToken)
    {
        Location location = await context.Locations.FirstOrDefaultAsync(l => l.Id == request.LocationId, cancellationToken)
                            ?? throw new Common.Exceptions.ValidationException([new ValidationFailure() {
                                                                                    ErrorMessage = "Location Id is not present in database"
                                                                                }]);
        VoltageLevel voltLvl = await context.VoltageLevels.FirstOrDefaultAsync(l => l.Id == request.VoltageLevelId, cancellationToken)
                            ?? throw new Common.Exceptions.ValidationException([new ValidationFailure() {
                                                                                    ErrorMessage = "Voltage level Id is not present in database"
                                                                                }]);
        string substationName = SubstationUtils.DeriveSubstationName(voltLvl.Level, location.Name);

        List<Owner> owners = await OwnerUtils.GetOwnersFromIdsAsync(request.OwnerIds, context, cancellationToken);

        string ownersCache = OwnerUtils.DeriveOwnersCache(owners);

        var entity = new Substation()
        {
            NameCache = substationName,
            OwnerNamesCache = ownersCache,
            RegionCache = location.RegionCache,
            VoltageLevelId = request.VoltageLevelId,
            LocationId = request.LocationId,
            IsAc = request.IsAc,
            Latitude = request.Latitude,
            Longitude = request.Longitude
        };

        context.Substations.Add(entity);

        await context.SaveChangesAsync(cancellationToken);

        // create substation owner objects
        foreach (Owner owner in owners)
        {
            var substationOwner = new SubstationOwner
            {
                OwnerId = owner.Id,
                SubstationId = entity.Id
            };
            context.SubstationOwners.Add(substationOwner);
        }
        await context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
