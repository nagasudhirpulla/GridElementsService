﻿using Core.Entities.Common;

namespace Core.Entities;

public class Region : AuditableEntity
{
    public required string Name { get; set; }
}