﻿using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Owner : AuditableEntity
{
    public required string Name { get; set; }
}