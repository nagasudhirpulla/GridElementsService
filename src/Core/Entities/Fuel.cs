﻿using Core.Entities.Common;

namespace Core.Entities;

public class Fuel : AuditableEntity
{
    public required string FuelName { get; set; }
}
