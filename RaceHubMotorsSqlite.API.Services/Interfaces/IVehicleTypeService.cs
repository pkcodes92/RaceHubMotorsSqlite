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

    /// <summary>
    /// This method definition will get a single vehicle type from the database.
    /// </summary>
    /// <param name="id">The primary key of the <see cref="VehicleType"/> - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    Task<VehicleType> GetVehicleTypeAsync(int id);

    /// <summary>
    /// This method definition will get a single vehicle type from the database.
    /// </summary>
    /// <param name="code">The vehicle type code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    Task<VehicleType> GetVehicleTypeAsync(string code);
}
