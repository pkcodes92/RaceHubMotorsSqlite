using RaceHubMotorsSqlite.API.DAL.Models;

namespace RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

/// <summary>
/// This interface will define methods that interact with the VehicleColor database entity.
/// </summary>
public interface IVehicleColorRepository
{
    /// <summary>
    /// This method definition will get all of the vehicle colors from the database.
    /// </summary>
    /// <returns>A unit of execution that contains a list of type <see cref="VehicleColor"/>.</returns>
    Task<List<VehicleColor>> GetAllVehicleColorsAsync();

    /// <summary>
    /// This method definition will get a single vehicle color from the database.
    /// </summary>
    /// <param name="vehicleColorId">The primary key of the VehicleColor entity - the ID.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> GetVehicleColorAsync(int vehicleColorId);

    /// <summary>
    /// This method definition will get a single vehicle color from the database.
    /// </summary>
    /// <param name="code">The code to search the database.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> GetVehicleColorAsync(string code);

    /// <summary>
    /// This method definition will add a new vehicle color to the database.
    /// </summary>
    /// <param name="vehicleColor">The new vehicle color information to be added.</param>
    /// <returns>A unit of execution that contains a type of <see cref="VehicleColor"/>.</returns>
    Task<VehicleColor> AddVehicleColorAsync(VehicleColor vehicleColor);
}