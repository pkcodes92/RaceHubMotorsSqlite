using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Vehicle Color entity.
/// </summary>
public interface IVehicleColorService
{
    /// <summary>
    /// This method definition gets all the vehicle colors from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
    Task<List<VehicleColor>> GetVehicleColorsAsync();
}