using Microsoft.EntityFrameworkCore;

namespace RaceHubMotorsSqlite.API.DAL.Context;

public partial class MotorsContext(DbContextOptions<MotorsContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}