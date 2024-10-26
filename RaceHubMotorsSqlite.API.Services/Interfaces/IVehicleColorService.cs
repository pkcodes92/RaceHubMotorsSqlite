using RaceHubMotorsSqlite.API.DTO.Models;
using RaceHubMotorsSqlite.API.DTO.Request;

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

    /// <summary>
    /// This method definition will get a single vehicle color from the database.
    /// </summary>
    /// <param name="id">The primary key of the <see cref="VehicleColor"/> - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> GetVehicleColorAsync(int id);

    /// <summary>
    /// This method definition will get a single vehicle color from the database.
    /// </summary>
    /// <param name="code">The code to search in the database.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> GetVehicleColorAsync(string code);

    /// <summary>
    /// This method definition will add a new vehicle color to the database.
    /// </summary>
    /// <param name="request">The new vehicle color being added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> AddVehicleColorAsync(AddVehicleColorRequest request);
}