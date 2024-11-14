﻿// <auto-generated />
using System;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations;

[DbContext(typeof(ApplicationDbContext))]
[Migration("20241025124507_IdsinCache")]
partial class IdsinCache
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

        modelBuilder.Entity("Core.Entities.ElementOwner", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<int>("ElementId")
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<int>("OwnerId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("ElementId");

                b.HasIndex("OwnerId");

                b.ToTable("ElementOwners");
            });

        modelBuilder.Entity("Core.Entities.Elements.Element", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("CommercialOperationDate")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("CommissioningDate")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("DeCommissioningDate")
                    .HasColumnType("TEXT");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasMaxLength(21)
                    .HasColumnType("TEXT");

                b.Property<int>("ElementNameCache")
                    .HasColumnType("INTEGER");

                b.Property<string>("ElementNumber")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<bool>("IsImportantGridElement")
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("OwnerNamesCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("RegionCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("Substation1Id")
                    .HasColumnType("INTEGER");

                b.Property<int?>("Substation2Id")
                    .HasColumnType("INTEGER");

                b.Property<int>("SubstationId1")
                    .HasColumnType("INTEGER");

                b.Property<int?>("SubstationId2")
                    .HasColumnType("INTEGER");

                b.Property<string>("VoltLevelCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("ElementNameCache")
                    .IsUnique();

                b.HasIndex("Substation1Id");

                b.HasIndex("Substation2Id");

                b.ToTable("Elements");

                b.HasDiscriminator().HasValue("Element");

                b.UseTphMappingStrategy();
            });

        modelBuilder.Entity("Core.Entities.Fuel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("FuelName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("FuelName")
                    .IsUnique();

                b.ToTable("Fuels");
            });

        modelBuilder.Entity("Core.Entities.GeneratingStationClassification", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Classification")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("GeneratingStationClassifications");
            });

        modelBuilder.Entity("Core.Entities.GeneratingStationType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("StationType")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("GeneratingStationTypes");
            });

        modelBuilder.Entity("Core.Entities.Location", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Alias")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("RegionCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("StateId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("Name")
                    .IsUnique();

                b.HasIndex("StateId");

                b.ToTable("Locations");
            });

        modelBuilder.Entity("Core.Entities.Owner", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("Name")
                    .IsUnique();

                b.ToTable("Owners");
            });

        modelBuilder.Entity("Core.Entities.Region", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("Name")
                    .IsUnique();

                b.ToTable("Regions");
            });

        modelBuilder.Entity("Core.Entities.State", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("RegionId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("Name")
                    .IsUnique();

                b.HasIndex("RegionId");

                b.ToTable("States");
            });

        modelBuilder.Entity("Core.Entities.Substation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasMaxLength(21)
                    .HasColumnType("TEXT");

                b.Property<bool>("IsAc")
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<double>("Latitude")
                    .HasColumnType("REAL");

                b.Property<int>("LocationId")
                    .HasColumnType("INTEGER");

                b.Property<double>("Longitude")
                    .HasColumnType("REAL");

                b.Property<string>("NameCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("OwnerIdsCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("RegionCache")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("VoltageLevelId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("LocationId");

                b.HasIndex("VoltageLevelId");

                b.ToTable("Substations");

                b.HasDiscriminator().HasValue("Substation");

                b.UseTphMappingStrategy();
            });

        modelBuilder.Entity("Core.Entities.SubstationOwner", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<int>("OwnerId")
                    .HasColumnType("INTEGER");

                b.Property<int>("SubstationId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("OwnerId");

                b.HasIndex("SubstationId");

                b.ToTable("SubstationOwners");
            });

        modelBuilder.Entity("Core.Entities.VoltageLevel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset>("Created")
                    .HasColumnType("TEXT");

                b.Property<string>("CreatedBy")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("LastModified")
                    .HasColumnType("TEXT");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("TEXT");

                b.Property<string>("Level")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("Level")
                    .IsUnique();

                b.ToTable("VoltageLevels");
            });

        modelBuilder.Entity("Infra.Identity.ApplicationUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("TEXT");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("INTEGER");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("PasswordHash")
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("TEXT");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("TEXT");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("INTEGER");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex");

                b.ToTable("AspNetUsers", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("TEXT");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex");

                b.ToTable("AspNetRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderKey")
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("TEXT");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("TEXT");

                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("Value")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

        modelBuilder.Entity("Core.Entities.Elements.Bay", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("BayType")
                    .HasColumnType("INTEGER");

                b.Property<int>("Element1Id")
                    .HasColumnType("INTEGER");

                b.Property<int>("Element2Id")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsFuture")
                    .HasColumnType("INTEGER");

                b.HasIndex("Element1Id");

                b.HasIndex("Element2Id");

                b.HasDiscriminator().HasValue("Bay");
            });

        modelBuilder.Entity("Core.Entities.Elements.Bus", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("BusType")
                    .HasColumnType("INTEGER");

                b.HasDiscriminator().HasValue("Bus");
            });

        modelBuilder.Entity("Core.Entities.Elements.BusReactor", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("BusId")
                    .HasColumnType("INTEGER");

                b.Property<double>("MvarCapacity")
                    .HasColumnType("REAL");

                b.HasIndex("BusId");

                b.HasDiscriminator().HasValue("BusReactor");
            });

        modelBuilder.Entity("Core.Entities.Elements.FilterBank", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<bool>("IsSwitchable")
                    .HasColumnType("INTEGER");

                b.Property<double>("Mvar")
                    .HasColumnType("REAL");

                b.HasDiscriminator().HasValue("FilterBank");
            });

        modelBuilder.Entity("Core.Entities.Elements.GeneratingUnit", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<double>("GeneratingVoltage")
                    .HasColumnType("REAL");

                b.Property<double>("InstalledCapacity")
                    .HasColumnType("REAL");

                b.HasDiscriminator().HasValue("GeneratingUnit");
            });

        modelBuilder.Entity("Core.Entities.Elements.HvdcLine", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("Bus1Id")
                    .HasColumnType("INTEGER");

                b.Property<int>("Bus2Id")
                    .HasColumnType("INTEGER");

                b.Property<string>("ConductorType")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<bool>("IsSpsPresent")
                    .HasColumnType("INTEGER");

                b.Property<double>("Length")
                    .HasColumnType("REAL");

                b.HasIndex("Bus1Id");

                b.HasIndex("Bus2Id");

                b.HasDiscriminator().HasValue("HvdcLine");
            });

        modelBuilder.Entity("Core.Entities.Elements.HvdcPole", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("PoleType")
                    .HasColumnType("INTEGER");

                b.HasDiscriminator().HasValue("HvdcPole");
            });

        modelBuilder.Entity("Core.Entities.Elements.Line", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("Bus1Id")
                    .HasColumnType("INTEGER");

                b.Property<int>("Bus2Id")
                    .HasColumnType("INTEGER");

                b.Property<string>("ConductorType")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<bool>("IsAutoReclosurePresent")
                    .HasColumnType("INTEGER");

                b.Property<double>("Length")
                    .HasColumnType("REAL");

                b.HasIndex("Bus1Id");

                b.HasIndex("Bus2Id");

                b.ToTable("Elements", t =>
                    {
                        t.Property("Bus1Id")
                            .HasColumnName("Line_Bus1Id");

                        t.Property("Bus2Id")
                            .HasColumnName("Line_Bus2Id");

                        t.Property("ConductorType")
                            .HasColumnName("Line_ConductorType");

                        t.Property("Length")
                            .HasColumnName("Line_Length");
                    });

                b.HasDiscriminator().HasValue("Line");
            });

        modelBuilder.Entity("Core.Entities.Elements.LineReactor", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<bool>("IsConvertible")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsSwitchable")
                    .HasColumnType("INTEGER");

                b.Property<int>("LineId")
                    .HasColumnType("INTEGER");

                b.Property<double>("MvarCapacity")
                    .HasColumnType("REAL");

                b.HasIndex("LineId");

                b.ToTable("Elements", t =>
                    {
                        t.Property("IsSwitchable")
                            .HasColumnName("LineReactor_IsSwitchable");

                        t.Property("MvarCapacity")
                            .HasColumnName("LineReactor_MvarCapacity");
                    });

                b.HasDiscriminator().HasValue("LineReactor");
            });

        modelBuilder.Entity("Core.Entities.Elements.SubFilterBank", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<int>("FilterBankId")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsSwitchable")
                    .HasColumnType("INTEGER");

                b.Property<double>("Mvar")
                    .HasColumnType("REAL");

                b.Property<string>("SubFilterTag")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasIndex("FilterBankId");

                b.ToTable("Elements", t =>
                    {
                        t.Property("IsSwitchable")
                            .HasColumnName("SubFilterBank_IsSwitchable");

                        t.Property("Mvar")
                            .HasColumnName("SubFilterBank_Mvar");
                    });

                b.HasDiscriminator().HasValue("SubFilterBank");
            });

        modelBuilder.Entity("Core.Entities.Elements.Transformer", b =>
            {
                b.HasBaseType("Core.Entities.Elements.Element");

                b.Property<double>("MvaCapacity")
                    .HasColumnType("REAL");

                b.Property<int>("TransformerType")
                    .HasColumnType("INTEGER");

                b.HasDiscriminator().HasValue("Transformer");
            });

        modelBuilder.Entity("Core.Entities.GeneratingStation", b =>
            {
                b.HasBaseType("Core.Entities.Substation");

                b.Property<int>("FuelId")
                    .HasColumnType("INTEGER");

                b.Property<int>("GeneratingStationClassificationId")
                    .HasColumnType("INTEGER");

                b.Property<int>("GeneratingStationTypeId")
                    .HasColumnType("INTEGER");

                b.Property<double>("Installedcapacity")
                    .HasColumnType("REAL");

                b.Property<double>("MVAcapacity")
                    .HasColumnType("REAL");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasIndex("FuelId");

                b.HasIndex("GeneratingStationClassificationId");

                b.HasIndex("GeneratingStationTypeId");

                b.HasIndex("Name")
                    .IsUnique();

                b.HasDiscriminator().HasValue("GeneratingStation");
            });

        modelBuilder.Entity("Core.Entities.ElementOwner", b =>
            {
                b.HasOne("Core.Entities.Elements.Element", "Element")
                    .WithMany("ElementOwners")
                    .HasForeignKey("ElementId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Owner", "Owner")
                    .WithMany("ElementOwners")
                    .HasForeignKey("OwnerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Element");

                b.Navigation("Owner");
            });

        modelBuilder.Entity("Core.Entities.Elements.Element", b =>
            {
                b.HasOne("Core.Entities.Substation", "Substation1")
                    .WithMany()
                    .HasForeignKey("Substation1Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Substation", "Substation2")
                    .WithMany()
                    .HasForeignKey("Substation2Id");

                b.Navigation("Substation1");

                b.Navigation("Substation2");
            });

        modelBuilder.Entity("Core.Entities.Location", b =>
            {
                b.HasOne("Core.Entities.State", "State")
                    .WithMany()
                    .HasForeignKey("StateId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("State");
            });

        modelBuilder.Entity("Core.Entities.State", b =>
            {
                b.HasOne("Core.Entities.Region", "Region")
                    .WithMany()
                    .HasForeignKey("RegionId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Region");
            });

        modelBuilder.Entity("Core.Entities.Substation", b =>
            {
                b.HasOne("Core.Entities.Location", "Location")
                    .WithMany()
                    .HasForeignKey("LocationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.VoltageLevel", "VoltageLevel")
                    .WithMany()
                    .HasForeignKey("VoltageLevelId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Location");

                b.Navigation("VoltageLevel");
            });

        modelBuilder.Entity("Core.Entities.SubstationOwner", b =>
            {
                b.HasOne("Core.Entities.Owner", "Owner")
                    .WithMany("SubstationOwners")
                    .HasForeignKey("OwnerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Substation", "Substation")
                    .WithMany("SubstationOwners")
                    .HasForeignKey("SubstationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Owner");

                b.Navigation("Substation");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("Infra.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("Infra.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Infra.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("Infra.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Core.Entities.Elements.Bay", b =>
            {
                b.HasOne("Core.Entities.Elements.Element", "Element1")
                    .WithMany()
                    .HasForeignKey("Element1Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Elements.Element", "Element2")
                    .WithMany()
                    .HasForeignKey("Element2Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Element1");

                b.Navigation("Element2");
            });

        modelBuilder.Entity("Core.Entities.Elements.BusReactor", b =>
            {
                b.HasOne("Core.Entities.Elements.Bus", "Bus")
                    .WithMany()
                    .HasForeignKey("BusId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Bus");
            });

        modelBuilder.Entity("Core.Entities.Elements.HvdcLine", b =>
            {
                b.HasOne("Core.Entities.Elements.Bus", "Bus1")
                    .WithMany()
                    .HasForeignKey("Bus1Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Elements.Bus", "Bus2")
                    .WithMany()
                    .HasForeignKey("Bus2Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Bus1");

                b.Navigation("Bus2");
            });

        modelBuilder.Entity("Core.Entities.Elements.Line", b =>
            {
                b.HasOne("Core.Entities.Elements.Bus", "Bus1")
                    .WithMany()
                    .HasForeignKey("Bus1Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.Elements.Bus", "Bus2")
                    .WithMany()
                    .HasForeignKey("Bus2Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Bus1");

                b.Navigation("Bus2");
            });

        modelBuilder.Entity("Core.Entities.Elements.LineReactor", b =>
            {
                b.HasOne("Core.Entities.Elements.Line", "Line")
                    .WithMany()
                    .HasForeignKey("LineId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Line");
            });

        modelBuilder.Entity("Core.Entities.Elements.SubFilterBank", b =>
            {
                b.HasOne("Core.Entities.Elements.FilterBank", "FilterBank")
                    .WithMany()
                    .HasForeignKey("FilterBankId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("FilterBank");
            });

        modelBuilder.Entity("Core.Entities.GeneratingStation", b =>
            {
                b.HasOne("Core.Entities.Fuel", "Fuel")
                    .WithMany()
                    .HasForeignKey("FuelId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.GeneratingStationClassification", "GeneratingStationClassification")
                    .WithMany()
                    .HasForeignKey("GeneratingStationClassificationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Core.Entities.GeneratingStationType", "GeneratingStationType")
                    .WithMany()
                    .HasForeignKey("GeneratingStationTypeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Fuel");

                b.Navigation("GeneratingStationClassification");

                b.Navigation("GeneratingStationType");
            });

        modelBuilder.Entity("Core.Entities.Elements.Element", b =>
            {
                b.Navigation("ElementOwners");
            });

        modelBuilder.Entity("Core.Entities.Owner", b =>
            {
                b.Navigation("ElementOwners");

                b.Navigation("SubstationOwners");
            });

        modelBuilder.Entity("Core.Entities.Substation", b =>
            {
                b.Navigation("SubstationOwners");
            });
#pragma warning restore 612, 618
    }
}
