﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Elements;
using Core.Enums;

namespace Infra.Data.Configurations;

public class BayConfiguration : IEntityTypeConfiguration<Bay>
{
    public void Configure(EntityTypeBuilder<Bay> builder)
    {
        builder.Property(p => p.BayType)
            .HasConversion(
                p => p.Value,
                p => BayTypeEnum.FromValue(p));
    }
}