﻿namespace Core.Entities;

/*
 * SubstationId, Filterbank number combination is unique
 */

public class FilterBank : AuditableEntity
{
    public int ElementId { get; set; }
    public required Element Element { get; set; }

    public int FilterBankNumber { get; set; }

    public int VoltageLevelId { get; set; }
    public required VoltageLevel VoltageLevel { get; set; }

    public double Mvar { get; set; }

    public bool IsSwitchable { get; set; }
}
