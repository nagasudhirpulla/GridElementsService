﻿using Core.Entities.Common;

namespace Core.Entities;

public class GeneratingStationType : AuditableEntity
{
    public required string StationType { get; set; }
}
