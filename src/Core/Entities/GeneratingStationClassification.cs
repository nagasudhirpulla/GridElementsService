﻿using Core.Entities.Common;

namespace Core.Entities;

public class GeneratingStationClassification : AuditableEntity
{
    public required string Classification { get; set; }
}
