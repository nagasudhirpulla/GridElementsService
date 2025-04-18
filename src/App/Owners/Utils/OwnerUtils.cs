﻿using App.Common.Interfaces;
using Core.Entities;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace App.Owners.Utils;

public static class OwnerUtils
{
    // TODO create file for each function
    public static string DeriveOwnersCache(IList<Owner> owners)
    {
        string ownersCache = String.Join("", owners.Select(o => o.Name + ";"));
        return ownersCache;
    }

    public static bool BeValidOwnerIds(string oIds)
    {
        return oIds.Split(',').Any(oId =>
        {
            int ownerId = -1;
            try
            {
                ownerId = Int32.Parse(oId);
            }
            catch (FormatException)
            {

                return false;
            }
            return true;
        });
    }

    public static async Task<List<Owner>> GetOwnersFromIdsAsync(string ownerIds, IApplicationDbContext context, CancellationToken cancellationToken)
    {
        List<Owner> owners = [];
        var idStrings = ownerIds.Split(",").Distinct();
        foreach (string ownerId in idStrings)
        {
            Owner owner = await context.Owners.FirstOrDefaultAsync(o => o.Id == Int32.Parse(ownerId), cancellationToken: cancellationToken)
                                ?? throw new Common.Exceptions.ValidationException([new ValidationFailure() {
                                                                                    ErrorMessage = "Owner Id is not present in database"
                                                                               }]);
            owners.Add(owner);
        }
        return owners;
    }

    public static async Task InsertElementOwnersAsync(int elementId, IEnumerable<int> ownerIds, IApplicationDbContext context, CancellationToken cancellationToken)
    {
        foreach (int ownerId in ownerIds)
        {
            var elementOwner = new ElementOwner
            {
                OwnerId = ownerId,
                ElementId = elementId
            };
            context.ElementOwners.Add(elementOwner);
        }
        await context.SaveChangesAsync(cancellationToken);
    }

    public static async Task<int> UpdateElementOwnersAsync(int elementId, IEnumerable<int> newOwnerIds, IApplicationDbContext context, CancellationToken cancellationToken)
    {
        var existingElementOwnerRecords = await context.ElementOwners.Where(s => s.ElementId == elementId).ToListAsync(cancellationToken: cancellationToken);
        var existingOwnerIds = existingElementOwnerRecords.Select(o => o.OwnerId).ToList();

        var ownerIdsToAdd = newOwnerIds.Where(o => !existingOwnerIds.Contains(o)).ToList();
        var ownerIdsToDelete = existingOwnerIds.Where(o => !newOwnerIds.Contains(o)).ToList();
        var numOwnerChanges = ownerIdsToAdd.Count + ownerIdsToDelete.Count;
        if (numOwnerChanges > 0)
        {
            foreach (var ownerId in ownerIdsToAdd)
            {
                context.ElementOwners.Add(new ElementOwner
                {
                    ElementId = elementId,
                    OwnerId = ownerId
                });
            }

            foreach (ElementOwner elementOwner in existingElementOwnerRecords.Where(so => ownerIdsToDelete.Contains(so.OwnerId)))
            {

                context.ElementOwners.Remove(elementOwner);
            }

        }
        return numOwnerChanges;
    }
}