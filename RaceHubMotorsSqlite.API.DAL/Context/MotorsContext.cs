// <copyright file="MotorsContext.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Context;

/// <summary>
/// Initializes an instance of <see cref="MotorsContext"/>.
/// </summary>
/// <param name="options">The necessary database context injection.</param>
public partial class MotorsContext(DbContextOptions<MotorsContext> options) : DbContext(options)
{
    /// <summary>
    /// The vehicle types table in the database.
    /// </summary>
    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    /// <summary>
    /// The manufacturers table in the database.
    /// </summary>
    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    /// <summary>
    /// The engines table in the database.
    /// </summary>
    public virtual DbSet<Engine> Engines { get; set; }

    /// <summary>
    /// The drivetrains table in the database.
    /// </summary>
    public virtual DbSet<Drivetrain> Drivetrains { get; set; }

    /// <summary>
    /// The vehicles table in the database.
    /// </summary>
    public virtual DbSet<Vehicle> Vehicles { get; set; }

    /// <summary>
    /// The vehicle colors table in the database.
    /// </summary>
    public virtual DbSet<VehicleColor> VehicleColors { get; set; }

    /// <summary>
    /// This method will bind the tables to the database C# objects.
    /// </summary>
    /// <param name="modelBuilder">The model building middleware.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.HasKey(e => e.VehicleTypeId);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId);
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.HasKey(e => e.EngineId);
        });

        modelBuilder.Entity<Drivetrain>(entity =>
        {
            entity.HasKey(e => e.DrivetrainId);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId);
        });

        modelBuilder.Entity<VehicleColor>(entity =>
        {
            entity.HasKey(e => e.VehicleColorId);
        });
    }
}