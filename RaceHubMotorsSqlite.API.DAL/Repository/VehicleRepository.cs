using Microsoft.EntityFrameworkCore;
using RaceHubMotorsSqlite.API.DAL.Context;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.DAL.Repository;

/// <summary>
/// Initializes an instance of <see cref="VehicleRepository"/>.
/// </summary>
/// <remarks>This class implements the method(s) defined in <see cref="IVehicleRepository"/>.</remarks>
/// <param name="context">The necessary database context injection.</param>
public class VehicleRepository(MotorsContext context) : IVehicleRepository
{
    private readonly MotorsContext context = context;

    /// <summary>
    /// This method implementation gets all of the vehicles from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Vehicle"/>.</returns>
    public async Task<List<Vehicle>> GetAllVehiclesAsync()
    {
        var results = await this.context.Vehicles.ToListAsync();
        return results!;
    }
}
