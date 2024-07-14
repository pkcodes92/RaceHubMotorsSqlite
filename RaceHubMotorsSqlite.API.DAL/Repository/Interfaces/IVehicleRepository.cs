using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface defines methods which interact with the Vehicle entity.
/// </summary>
public interface IVehicleRepository
{
    /// <summary>
    /// This method definition will get all the vehicles from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="Vehicle"/>.</returns>
    Task<List<Vehicle>> GetAllVehiclesAsync();
}
