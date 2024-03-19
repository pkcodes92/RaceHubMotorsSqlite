using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Context;

public partial class MotorsContext(DbContextOptions<MotorsContext> options) : DbContext(options)
{
    public virtual DbSet<VehicleType> VehicleTypes { get; set;}

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Engine> Engines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VehicleType>(entity => 
        {
            entity.HasKey(e => e.VehicleTypeId);
        });

        modelBuilder.Entity<Manufacturer>(entity => {
            entity.HasKey(e => e.ManufacturerId);
        });

        modelBuilder.Entity<Engine>(entity => {
            entity.HasKey(e => e.EngineId);
        });
    }
}