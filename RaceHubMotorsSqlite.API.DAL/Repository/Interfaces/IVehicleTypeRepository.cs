using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface defines methods that interact with the vehicle type repository.
/// </summary>
public interface IVehicleTypeRepository
{
    /// <summary>
    /// This method definition will get all the vehicle types from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleType"/>.</returns>
    Task<List<VehicleType>> GetAllVehicleTypesAsync();

    /// <summary>
    /// This method definition will get a single vehicle type from the database.
    /// </summary>
    /// <param name="id">The primary key of the vehicle type entity.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    Task<VehicleType> GetVehicleTypeByIdAsync(int id);

    /// <summary>
    /// This method definition will get a single vehicle type from the database.
    /// </summary>
    /// <param name="code">The code to search.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    Task<VehicleType> GetVehicleTypeByCodeAsync(string code);

    /// <summary>
    /// This method definition will add a new vehicle type to the database.
    /// </summary>
    /// <param name="vehicleType">The new vehicle type information.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleType"/>.</returns>
    Task<VehicleType> AddVehicleTypeAsync(VehicleType vehicleType);
}