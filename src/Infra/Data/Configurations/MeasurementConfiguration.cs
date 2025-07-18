﻿using Core.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class MeasurementConfiguration : IEntityTypeConfiguration<Measurement>
{
    public void Configure(EntityTypeBuilder<Measurement> builder)
    {
        builder.HasKey(e => new { e.EntityId, e.MetricId, e.DatasourceId });

        builder
            .HasOne(o => o.Entity)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(o => o.Metric)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(o => o.Datasource)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
    }
}