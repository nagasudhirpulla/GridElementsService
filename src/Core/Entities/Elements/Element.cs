﻿using Core.Entities.Common;

namespace Core.Entities.Elements;

/*
if the element type is not a line or transformer substationID2 should be null
if the element type is transformer substationID1 and substationID2 should belong to the same location
if the element type is transmission line substationID1 and substationID2 should not belong to the same location
combination of substationID1, substationID2, elementType, elementNumber is unique for non bus elements
combination of substationID1, substationID2, elementNumber,busType is unique for bus element type

TODOs
FSC
 */

public class Element : AuditableEntity
{
    public int ElementNameCache { get; set; }

    public required string VoltLevelCache { get; set; }

    public Substation Substation1 { get; set; } = null!;
    public int SubstationId1 { get; set; }

    public Substation? Substation2 { get; set; }
    public int? SubstationId2 { get; set; }

    public required string OwnerNamesCache { get; set; }

    public List<ElementOwner> ElementOwners { get; } = [];

    public required string ElementNumber { get; set; }

    public DateTime CommissioningDate { get; set; }

    public DateTime DeCommissioningDate { get; set; }

    public DateTime CommercialOperationDate { get; set; }

    public Location Location { get; set; } = null!;
    public int LocationId { get; set; }

    public bool IsImportantGridElement { get; set; } = false;
}
