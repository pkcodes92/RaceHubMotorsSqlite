using RaceHubMotorsSqlite.API.DTO;
using RaceHubMotorsSqlite.API.DTO.Models;

namespace RaceHubMotorsSqlite.API.Services.Interfaces;

/// <summary>
/// This interface defines methods that interact with the Vehicle Type entity.
/// </summary>
public interface IVehicleTypeService
{
    /// <summary>
    /// This method definition will get all the vehicle types from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
    Task<List<VehicleType>> GetVehicleTypesAsync();

    Task<VehicleType> GetVehicleTypeAsync(int id);

    Task<VehicleType> GetVehicleTypeAsync(string code);
}
