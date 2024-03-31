using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Context;

public partial class MotorsContext(DbContextOptions<MotorsContext> options) : DbContext(options)
{
    public virtual DbSet<VehicleType> VehicleTypes { get; set;}

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Engine> Engines { get; set; }

    public virtual DbSet<Drivetrain> Drivetrains { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleColor> VehicleColors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VehicleType>(entity => {
            entity.HasKey(e => e.VehicleTypeId);
        });

        modelBuilder.Entity<Manufacturer>(entity => {
            entity.HasKey(e => e.ManufacturerId);
        });

        modelBuilder.Entity<Engine>(entity => {
            entity.HasKey(e => e.EngineId);
        });

        modelBuilder.Entity<Drivetrain>(entity => {
            entity.HasKey(e => e.DrivetrainId);
        });

        modelBuilder.Entity<Vehicle>(entity => {
            entity.HasKey(e => e.VehicleId);
        });

        modelBuilder.Entity<VehicleColor>(entity => {
            entity.HasKey(e => e.VehicleColorId);
        });
    }
}